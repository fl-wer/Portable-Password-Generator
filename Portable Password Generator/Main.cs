using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portable_Password_Generator
{
    public partial class Main : Form
    {
        public Main() { InitializeComponent(); }

        // default exe location that will be used for variables below
        // this is because registry running software on startup
        // makes the default directory for this .exe system32
        static string softwareDirectory = AppDomain.CurrentDomain.BaseDirectory;

        // information file names, these are files that store all
        // kind of information and are saved in software default folder in variable below
        // all those files will have "INF" at the end so you know these
        string passwordLengthINF = softwareDirectory + "\\" + "4matrz";
        string characterPoolINF = softwareDirectory + "\\" + "y42dew";
        string startWithWindowsINF = softwareDirectory + "\\" + "b4epqk";
        string lettersINF = softwareDirectory + "\\" + "8mzgzg";

        // option file names, these variables are real checkers
        // for anything that is happening in the code
        // they are getting downloaded on startup from files above
        int passwordLengthOPT = 6;
        string characterPoolOPT = "Letters, Numbers, Special";
        // startWithWindowsOPT not required because it has no checks
        string lettersOPT = "Lower, Upper";

        private void Form1_Load(object sender, EventArgs e) { ShowInTaskbar = false; Hide(); loadOptions(); }

        // closing app after choosing exit on tray icon menu strip
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) { Application.Exit(); }

        // when user clicks "generate" in context menu strip on tray icon
        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random randomGen = new Random(); // engine used for generating number for char pool array
            string generatedPassword = ""; // generating blank string that will have our

            // creating class object with all character pools
            CharacterPool globalPool = new CharacterPool();

            // setting up pool based on selection option
            // default will be exNone
            string characterPool = globalPool.exNone;

            if (characterPoolOPT == "Letters") characterPool = globalPool.exNumbersSpecial;
            else if (characterPoolOPT == "Letters, Numbers") characterPool = globalPool.exSpecial;
            else if (characterPoolOPT == "Letters, Special") characterPool = globalPool.exNumbers;
            else if (characterPoolOPT == "Letters, Numbers, Special") characterPool = globalPool.exNumbersSpecial;

            // generating password by taking random characters from character pool
            for (int i = 0; i < passwordLengthOPT; i++)
            {
                // default non-modified character
                char character = characterPool[randomGen.Next(0, characterPool.Length)];

                // we're not checking if "Lower" because character pool by default
                // contains only lower characters so don't have to do anything there
                // changing all to upper if option is upper only
                if (lettersOPT == "Upper") character = char.ToUpper(character);

                // randomizing lower with upper if both set to available
                else if (lettersOPT == "Lower, Upper" && randomGen.Next(0, 2) == 1)
                    character = char.ToUpper(character);

                // adding next character to generated password
                generatedPassword += character;
            }

            // changing clipboard to the generated password
            Clipboard.SetText(generatedPassword);
        }

        // overloading closing form so we could make it minimize only and stay
        // available in tray instead of closing completely
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        { if (e.CloseReason == CloseReason.UserClosing) { trayIcon.Visible = true; Hide(); e.Cancel = true; } }

        // password length change - click on menu strip
        private void changePasswordLength (object sender, EventArgs e)
        {
            // getting object that triggered this, it would always be strip menu item
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            // unchecking previous password length menu strip item
            ((ToolStripMenuItem)passwordLengthToolStripMenuItem.DropDownItems[passwordLengthOPT - 1]).Checked = false;

            // parsing new password length
            if (!int.TryParse(menuItem.Text, out passwordLengthOPT))
                passwordLengthOPT = 6;

            // checking selected new password length
            menuItem.Checked = true;

            // saving this option to a INF file
            File.WriteAllText(passwordLengthINF, passwordLengthOPT.ToString());
        }

        // changing selected character pool in options
        // saving to a file and managing checkboxes on menu items
        private void changeCharacterPool(object sender, EventArgs e)
        {
            // getting object that triggered this, it would always be strip menu item
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            // unchecking all options first
            for (int i = 0; i < 4; i++)
                ((ToolStripMenuItem)characterPoolToolStripMenuItem.DropDownItems[i]).Checked = false;

            // checking selected new password length
            menuItem.Checked = true;

            // changing options according to the displayed text on menu items
            // like "Letters" or "Letters, Special"
            characterPoolOPT = menuItem.Text;

            // saving this option to a INF file
            File.WriteAllText(characterPoolINF, characterPoolOPT);
        }

        // changing start with windows option
        // saving to a file and managing checkboxes on menu items
        private void changeStartWithWindows(object sender, EventArgs e)
        {
            // getting object that triggered this, it would always be strip menu item
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            // unchecking all options first
            for (int i = 0; i < 2; i++)
                ((ToolStripMenuItem)startWithWindowsToolStripMenuItem.DropDownItems[i]).Checked = false;

            // checking selected new password length
            menuItem.Checked = true;

            // creating registry key object that we oculd use to add/remove keys
            RegistryKey rkStartWithWindows =
                Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            // changing options according to the displayed text on menu items like "Yes" or "No"
            if (menuItem.Text == "Yes")
            {
                // setting autorun key
                rkStartWithWindows.SetValue("fl-wer Portable Password Generator", Application.ExecutablePath);
            }
            else
            {
                // removing windows autorun key if exists
                if (rkStartWithWindows.GetValue("fl-wer Portable Password Generator") != null)
                    rkStartWithWindows.DeleteValue("fl-wer Portable Password Generator");
            }

            // saving this option to a INF file
            File.WriteAllText(startWithWindowsINF, menuItem.Text);
        }

        // change letters type
       private void changeLetters(object sender, EventArgs e)
        {
            // getting object that triggered this, it would always be strip menu item
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            // unchecking all options first
            for (int i = 0; i < 3; i++)
                ((ToolStripMenuItem)lettersToolStripMenuItem1.DropDownItems[i]).Checked = false;

            // checking selected new letters type
            menuItem.Checked = true;

            // changing options (used for checks)
            lettersOPT = menuItem.Text;

            // saving new option to file
            // saving this option to a INF file
            File.WriteAllText(lettersINF, menuItem.Text);
        }

        // this load options from INF files and sets checkbox + OPT variables
        private void loadOptions()
        {
            // ### password length
            if (File.Exists(passwordLengthINF))
            {
                // temporary var used for checks
                int tempPasswordLength = 0;

                // trying to parse text read from INF file and then doing some
                // length checks, max is 16 characters
                if (int.TryParse(File.ReadAllText(passwordLengthINF), out tempPasswordLength) &&
                tempPasswordLength >= 0 && tempPasswordLength <= 16)
                    passwordLengthOPT = tempPasswordLength;

                // untick the default menu strip
                if (passwordLengthOPT != 6)
                    ((ToolStripMenuItem)passwordLengthToolStripMenuItem.DropDownItems[5]).Checked = false;
            }

            // changing correct item in menu strip to checked, minus 1
            // because we start with 1 and arrays with 0
            ((ToolStripMenuItem)passwordLengthToolStripMenuItem.DropDownItems[passwordLengthOPT - 1]).Checked = true;

            // ### character pool
            if (File.Exists(characterPoolINF))
            {
                // reading character pool option from file
                characterPoolOPT = File.ReadAllText(characterPoolINF);

                // untick the default menu strip
                ((ToolStripMenuItem)characterPoolToolStripMenuItem.DropDownItems[3]).Checked = false;

                // changing checkbox accordingly
                if (characterPoolOPT == "Letters") ((ToolStripMenuItem)characterPoolToolStripMenuItem.DropDownItems[0]).Checked = true;
                else if (characterPoolOPT == "Letters, Numbers") ((ToolStripMenuItem)characterPoolToolStripMenuItem.DropDownItems[1]).Checked = true;
                else if (characterPoolOPT == "Letters, Special") ((ToolStripMenuItem)characterPoolToolStripMenuItem.DropDownItems[2]).Checked = true;
                else if (characterPoolOPT == "Letters, Numbers, Special") ((ToolStripMenuItem)characterPoolToolStripMenuItem.DropDownItems[3]).Checked = true;

                // changing to default if none of above
                else characterPoolOPT = "Letters, Numbers, Special";
            }

            // ### start with windows
            if (File.Exists(startWithWindowsINF))
            {
                // temporary assignment for checks
                string tempStartWithWindows = File.ReadAllText(startWithWindowsINF);

                // checking if Yes or No
                if (tempStartWithWindows == "Yes")
                {
                    // checking clicked menu item
                    ((ToolStripMenuItem)startWithWindowsToolStripMenuItem.DropDownItems[0]).Checked = true;

                    // unchecking selected by default
                    ((ToolStripMenuItem)startWithWindowsToolStripMenuItem.DropDownItems[1]).Checked = false;
                }
            }

            // ### letters
            if (File.Exists(lettersINF))
            {
                // temporary assignment for checks
                string tempStartWithWindows = File.ReadAllText(lettersINF);

                // unchecking default option
                ((ToolStripMenuItem)lettersToolStripMenuItem1.DropDownItems[2]).Checked = false;

                // assigning to options what we read from file
                // this will be checked and edited if required in next lines
                lettersOPT = tempStartWithWindows;

                // checking which one was saved in files
                if (tempStartWithWindows == "Lower")
                    ((ToolStripMenuItem)lettersToolStripMenuItem1.DropDownItems[0]).Checked = true;
                else if (tempStartWithWindows == "Upper")
                    ((ToolStripMenuItem)lettersToolStripMenuItem1.DropDownItems[1]).Checked = true;
                else if (tempStartWithWindows == "Lower, Upper")
                    ((ToolStripMenuItem)lettersToolStripMenuItem1.DropDownItems[2]).Checked = true;

                // inside file was some gibberish therefore setting back to default
                else
                {
                    lettersOPT = "Lower, Upper";
                    ((ToolStripMenuItem)lettersToolStripMenuItem1.DropDownItems[2]).Checked = true;
                }
            }
        }
    }
}
