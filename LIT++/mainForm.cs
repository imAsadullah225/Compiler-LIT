using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;


namespace LIT__
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

//====================================< Start Compiler Code >=========================================//

        private void start_PB_Click(object sender, EventArgs e)
        {
            token_LV.Items.Clear();
            error_LV.Items.Clear();
            allTokens.Clear();

            char[] separators = new char[] { ' ', '\n' };
            string[] Input = CodeArea_RB.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            LexicalAnalyzer(Input);
            syntaxAnalyzer(Input);
        }


//=======================================< Lexical Analyzer Code >=========================================//

        string[] operators = { "+", "-", "*", "/", "++", "--", "%", ">", "<", "==", ">=", "<=", "!=", ",", ";", "=", ")", "(", "}", "{" };        
        
        string[] dataTypes = { "int", "string", "double", "float", "bool", "char", "decimal", "byte", "short", "long" };
       
        string[] keyWords = { "abstract", "as", "base", "break", "case", "catch", "checked", "public", 
                                  "static", "switch", "class", "do", "while", "if", "else", "for", "private", "foreach", 
                                  "return", "goto", "using", "void", "try", "null", "this", "true", "false", "default" };

        List<string> allTokens = new List<string>();
        public void LexicalAnalyzer(string[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                //DataTypes
                if (dataTypes.Contains(input[i]))
                {
                    token_LV.Items.Add("<DataType, " + input[i] + ">");
                    allTokens.Add(input[i]);
                }

                //Keywords
                if(keyWords.Contains(input[i]))
                {
                    token_LV.Items.Add("<Keyword, " + input[i] + ">");
                    allTokens.Add(input[i]);
                }

                //Operators
                if (operators.Contains(input[i]) && input[i] != "," && input[i] != ";" && input[i] != "=" && input[i] != "{" && input[i] != "}" && input[i] != "(" && input[i] != ")")
                {
                    token_LV.Items.Add("<Operator, " + input[i] + ">");
                    allTokens.Add(input[i]);
                }

                if (input[i] == ";")
                {
                    token_LV.Items.Add("<Terminator, " + input[i] + ">");
                    allTokens.Add(input[i]);
                }

                if (input[i] == ",")
                {
                    token_LV.Items.Add("<Separator Operator, " + input[i] + ">");
                    allTokens.Add(input[i]);
                }

                if (input[i] == "=")
                {
                    token_LV.Items.Add("<Assignment Operator, " + input[i] + ">");
                    allTokens.Add(input[i]);
                }

                if (input[i] == "{" || input[i] == "}" || input[i] == "(" || input[i] == ")")
                {
                    token_LV.Items.Add("<Special Operator, " + input[i] + ">");
                    allTokens.Add(input[i]);
                }

                //Identifiers
                try
                {
                    int intValue;
                    bool boolValue;
                    double doubleValue;

                    if (Int32.TryParse(input[i], out intValue) ||
                        Double.TryParse(input[i], out doubleValue) ||
                        bool.TryParse(input[i], out boolValue) || input[i].Contains('"') || input[i].Contains("'"))
                    {
                        token_LV.Items.Add("<Literal, " + input[i] + ">");
                        allTokens.Add(input[i]);
                    }

                    else if (input.Length > 0 && !dataTypes.Contains(input[i]) &&
                        !operators.Contains(input[i]) && !keyWords.Contains(input[i]) &&
                        !Int32.TryParse(input[i], out intValue) && !input[i].Contains('"'))
                    {
                        token_LV.Items.Add("<Identifier, " + input[i] + ">");
                        allTokens.Add(input[i]);
                    }
                }
                catch (Exception) { };
            }                  
        }

//====================================</ Lexical Analyer Code End >==================================//


//===================================< Syntax Analyzer Code>=========================================//

        public void syntaxAnalyzer(string[] input)
        {
            string[] codeLines = CodeArea_RB.Lines;

            if(!CodeArea_RB.Text.Contains("main()"))
                error_LV.Items.Add("Error! Code not contains Main() body.");

                for (int i = 0; i < codeLines.Length; i++)
                {
                    try
                    {
                        if (codeLines[i] != "" && codeLines[i] != "main()" && codeLines[i] != "void main()" &&
                            codeLines[i] != "{" && codeLines[i] != "}" && !codeLines[i].Contains(";"))
                        {
                            error_LV.Items.Add("Error! Line terminator ';' is expected at Line " + (i + 1) + ".");
                        }
                    }
                    catch (Exception) { };
                }

                int intValue;

                for (int i = 0; i < allTokens.Count; i++)
                {
                    try
                    {
                        if (dataTypes.Contains(allTokens[i]))
                        {
                            if (allTokens[i + 1].Length > 0 && !dataTypes.Contains(allTokens[i + 1]) &&
                                !operators.Contains(allTokens[i + 1]) && !keyWords.Contains(allTokens[i + 1]) &&
                                !Int32.TryParse(allTokens[i + 1], out intValue) && !allTokens[i + 1].Contains('"'))
                            {
                                if (allTokens[i + 2] == ",")
                                {
                                    if (allTokens[i + 3].Length > 0 && !dataTypes.Contains(allTokens[i + 3]) &&
                                       !operators.Contains(allTokens[i + 3]) && !keyWords.Contains(allTokens[i + 3]) &&
                                       !Int32.TryParse(allTokens[i + 3], out intValue) && !allTokens[i + 3].Contains('"'))
                                    {

                                    }
                                    else
                                    {
                                        error_LV.Items.Add("Error! Identifier expected.");
                                    }
                                }
                                else if (allTokens[i + 2].Length > 0 && !dataTypes.Contains(allTokens[i + 2]) &&
                                        !operators.Contains(allTokens[i + 2]) && !keyWords.Contains(allTokens[i + 2]) &&
                                        !Int32.TryParse(allTokens[i + 2], out intValue) && !allTokens[i + 2].Contains('"'))
                                {
                                    error_LV.Items.Add("Error! Separator ',' expected.");
                                }
                                else if (allTokens[i + 2] == "=")
                                {                     
                                    bool boolValue;
                                    double doubleValue;

                                    if (Int32.TryParse(allTokens[i + 3], out intValue) ||
                                        Double.TryParse(allTokens[i + 3], out doubleValue) ||
                                        bool.TryParse(allTokens[i + 3], out boolValue) || allTokens[i + 3].Contains('"') ||
                                        allTokens[i + 3].Length > 0 && !dataTypes.Contains(allTokens[i + 3]) &&
                                        !operators.Contains(allTokens[i + 3]) && !keyWords.Contains(allTokens[i + 3]) &&
                                        !Int32.TryParse(allTokens[i + 3], out intValue) && !allTokens[i + 3].Contains('"'))
                                    {
                                        if (allTokens[i] == "int" && !Int32.TryParse(allTokens[i + 3], out intValue))
                                        {
                                            error_LV.Items.Add("Error! Cannot implicitly convert this type to int.");
                                        }

                                        if (allTokens[i] == "double" && !Double.TryParse(allTokens[i + 3], out doubleValue))
                                        {
                                            error_LV.Items.Add("Error! Cannot implicitly convert this type to double.");
                                        }
                                        if (allTokens[i] == "bool" && !bool.TryParse(allTokens[i + 3], out boolValue))
                                        {
                                            error_LV.Items.Add("Error! Cannot implicitly convert this type to bool.");
                                        }

                                        if (allTokens[i] == "string" && !allTokens[i + 3].Contains('"'))
                                        {
                                            error_LV.Items.Add("Error! Cannot implicitly convert this type to string.");
                                        }

                                        if (allTokens[i] == "char" && !allTokens[i + 3].Contains("'"))
                                        {

                                            error_LV.Items.Add("Error! Cannot implicitly convert this type to char.");
                                        }
                                        else
                                        {
                                            if (allTokens[i + 3].Length < 3 && allTokens[i] != "string" && allTokens[i] != "int" && allTokens[i] != "double" && allTokens[i] != "bool")
                                            {
                                                error_LV.Items.Add("Error! Empty character Literal.");
                                            }
                                            else if (allTokens[i + 3].Length > 3 && allTokens[i] != "string" && allTokens[i] != "int" && allTokens[i] != "double" && allTokens[i] != "bool")
                                            {
                                                error_LV.Items.Add("Error! Too many characters in character Literal.");
                                            }
                                        }                                          
                                    }
                                    else
                                    {
                                        error_LV.Items.Add("Error! Invalid Expression term.");
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        error_LV.Items.Add("Error! Syntax Incomplete or Incorrect.");
                    }
                }
        }

//===================================</ Syntax Analyzer Code End >===================================//


//====================================</ End Compliler >=============================================// 


//====================================< Start UI Code >=============================================//

        #region Close, Fit, Minimize Buttons Code
        private void closePB_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void fitPB_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void minmizedPB_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Syntax Color Code
        private void ColorKeyword(string word, Color color, int startIndex)
        {
            if (this.CodeArea_RB.Text.Contains(word))
            {
                int index = -1;
                int selectStart = this.CodeArea_RB.SelectionStart;

                while ((index = this.CodeArea_RB.Text.IndexOf(word, (index + 1))) != -1)
                {
                    this.CodeArea_RB.Select((index + startIndex), word.Length);
                    this.CodeArea_RB.SelectionColor = color;
                    this.CodeArea_RB.Select(selectStart, 0);
                    this.CodeArea_RB.SelectionColor = Color.DarkGray;
                }
            }
        }
        private void CodeArea_RB_TextChanged(object sender,  EventArgs e)
        {
            //ClearTokens
            if (CodeArea_RB.Text.Count() == 0)
            {
                token_LV.Items.Clear();
                error_LV.Items.Clear();
                allTokens.Clear();
            }

            //Seprate Word for Color Syntax
            char[] separators = new char[] { ' ', '\n' };
            string[] word = CodeArea_RB.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < dataTypes.Count(); j++)
                {
                    if(word[i] == dataTypes[j])
                        this.ColorKeyword(word[i], Color.FromArgb(14, 129, 201), 0);                   
                }

                for (int j = 0; j < keyWords.Count(); j++)
                {
                    if (word[i] == keyWords[j])
                        this.ColorKeyword(word[i], Color.SeaGreen, 0);
                }

            }

            //Line Counter
            if (CodeArea_RB.Text == "")
                AddLineNumbers();
        }

        #endregion

        #region Code Lines Counter Code
        public int getWidth()
        {
            int w = 25;
            // get total lines of richTextBox1    
            int line = CodeArea_RB.Lines.Length;

            if (line <= 99 || line <= 999)
                w = 35 + (int)CodeArea_RB.Font.Size;

            else
                w = 35 + (int)CodeArea_RB.Font.Size;

            return w;
        }

        public void AddLineNumbers()
        {
            // create & set Point pt to (0,0)    
            Point pt = new Point(0, 0);
            // get First Index & First Line from richTextBox   
            int First_Index = CodeArea_RB.GetCharIndexFromPosition(pt);
            int First_Line = CodeArea_RB.GetLineFromCharIndex(First_Index);
            // set X & Y coordinates of Point pt to ClientRectangle Width & Height respectively    
            pt.X = ClientRectangle.Width;
            pt.Y = ClientRectangle.Height;
            // get Last Index & Last Line from richTextBox    
            int Last_Index = CodeArea_RB.GetCharIndexFromPosition(pt);
            int Last_Line = CodeArea_RB.GetLineFromCharIndex(Last_Index + 1);
            // set Center alignment to linesCounter    
            linesCounter.SelectionAlignment = HorizontalAlignment.Center;
            // set linesCounter text to null & width to getWidth() function value    
            linesCounter.Text = "";
            linesCounter.Width = getWidth();
            // now add each line number to linesCounter upto last line    

            for (int i = First_Line; i <= Last_Line; i++)
                linesCounter.Text += i + 1 + "\n";
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            linesCounter.Font = CodeArea_RB.Font;
            CodeArea_RB.Select();
            AddLineNumbers();
        }

        private void CodeArea_RB_SelectionChanged(object sender, EventArgs e)
        {
            Point pt = CodeArea_RB.GetPositionFromCharIndex(CodeArea_RB.SelectionStart);

            if (pt.X == 1)
                AddLineNumbers();
        }

        private void CodeArea_RB_VScroll(object sender, EventArgs e)
        {
            linesCounter.Text = "";
            AddLineNumbers();
            linesCounter.Invalidate();
        }

        private void CodeArea_RB_FontChanged(object sender, EventArgs e)
        {
            linesCounter.Font = CodeArea_RB.Font;
            CodeArea_RB.Select();
            AddLineNumbers();
        }

        private void CodeArea_RB_MouseDown(object sender, MouseEventArgs e)
        {
            CodeArea_RB.Select();
            linesCounter.DeselectAll();
        }

        private void mainForm_Resize(object sender, EventArgs e)
        {
            AddLineNumbers();
        }

        #endregion

        #region Resize Form Code
        protected override void WndProc(ref Message m)
        {
            const int wmNcHitTest = 0x84;
            const int htLeft = 10;
            const int htRight = 11;
            const int htTop = 12;
            const int htTopLeft = 13;
            const int htTopRight = 14;
            const int htBottom = 15;
            const int htBottomLeft = 16;
            const int htBottomRight = 17;

            if (m.Msg == wmNcHitTest)
            {
                int x = (int)(m.LParam.ToInt64() & 0xFFFF);
                int y = (int)((m.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point pt = PointToClient(new Point(x, y));
                Size clientSize = ClientSize;
                ///allow resize on the lower right corner
                if (pt.X >= clientSize.Width - 16 && pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16 && WindowState != FormWindowState.Maximized)
                {
                    m.Result = (IntPtr)(IsMirrored ? htBottomLeft : htBottomRight);
                    return;
                }
                ///allow resize on the lower left corner
                if (pt.X <= 16 && pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16 && WindowState != FormWindowState.Maximized)
                {
                    m.Result = (IntPtr)(IsMirrored ? htBottomRight : htBottomLeft);
                    return;
                }
                ///allow resize on the upper right corner
                if (pt.X <= 16 && pt.Y <= 16 && clientSize.Height >= 16 && WindowState != FormWindowState.Maximized)
                {
                    m.Result = (IntPtr)(IsMirrored ? htTopRight : htTopLeft);
                    return;
                }
                ///allow resize on the upper left corner
                if (pt.X >= clientSize.Width - 16 && pt.Y <= 16 && clientSize.Height >= 16 && WindowState != FormWindowState.Maximized)
                {
                    m.Result = (IntPtr)(IsMirrored ? htTopLeft : htTopRight);
                    return;
                }
                ///allow resize on the top border
                if (pt.Y <= 16 && clientSize.Height >= 16 && WindowState != FormWindowState.Maximized)
                {
                    m.Result = (IntPtr)(htTop);
                    return;
                }
                ///allow resize on the bottom border
                if (pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16 && WindowState != FormWindowState.Maximized)
                {
                    m.Result = (IntPtr)(htBottom);
                    return;
                }
                ///allow resize on the left border
                if (pt.X <= 16 && clientSize.Height >= 16 && WindowState != FormWindowState.Maximized)
                {
                    m.Result = (IntPtr)(htLeft);
                    return;
                }
                ///allow resize on the right border
                if (pt.X >= clientSize.Width - 16 && clientSize.Height >= 16 && WindowState != FormWindowState.Maximized)
                {
                    m.Result = (IntPtr)(htRight);
                    return;
                }
            }
            base.WndProc(ref m);
        }
        #endregion

//=====================================</ End UI Code >=================================//
    }
}