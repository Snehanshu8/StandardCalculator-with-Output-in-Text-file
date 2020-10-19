using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StandardCalculator
{
    public partial class Form1 : Form
    {
        //Defining Variables, Operands and Operators

        bool isNewEntry = false, isInfinityException = false, isRepeatLastOperation = false,
            isPressedYes = false, isPressedNo = false, isSaveAgain = false, isRepeatOperation = false, 
            isNextOperation = false, isContOperation = false, isContOperand = false;
        double dblResult, dblOperand, Num1 = 0;
        char chPreviousOperator = new char();
        string HistoryText = string.Empty;

        public Form1() 
        {
            InitializeComponent();
        }

        //Displaying Function For Numbers and Operators
        private void UpdateOperand(object sender, EventArgs e)
        {
            if(!isInfinityException)
            {
                if(isNewEntry)
                {
                    textBox1.Text = "0";
                    isContOperand = true;
                    if (isNextOperation == true)
                    {
                        HistoryText = string.Empty;
                        isContOperand = false;
                    }
                    isNewEntry = false;
                }

                //Checking if we are in Repeat state or not
                if(isRepeatLastOperation)
                {
                    chPreviousOperator = '\0';
                    dblResult = 0;
                    isContOperation = true;
                }

                //Condition To Check for DecimalPoint and Zero
                if (!(textBox1.Text == "0" && (Button)sender == btn0) &&
                    !(((Button)sender) == btnDecimalPoint && textBox1.Text.Contains(".")))
                    textBox1.Text = (textBox1.Text == "0" && ((Button)sender) == btnDecimalPoint) ? "0." :
                        ((textBox1.Text == "0") ? ((Button)sender).Text : textBox1.Text + ((Button)sender).Text);

            }
        }

        //Clears Previous Symbol or Digit
        private void ClearOperator(object sender, EventArgs e)
        {
            isInfinityException = false;
            textBox1.Text = "0";

            //Clears the Data From text file
            File.WriteAllText("..//..//SaveData.txt", string.Empty); 
        }

        //Clears Everything
        private void ClearAll(object sender, EventArgs e)
        {
            isInfinityException = isRepeatLastOperation = false;
            dblOperand = dblResult = 0; textBox1.Text = "0";
            isNewEntry = true;
            chPreviousOperator = '\0';
            HistoryText = string.Empty;

            //Clears the Data from text file
            File.WriteAllText("..//..//SaveData.txt", string.Empty);
        }
        
        //Defining the operation of Operators
        private void OperatorFound(object sender, EventArgs e)
        {
            if (!isInfinityException)
            {
                if (chPreviousOperator == '\0')
                {
                    chPreviousOperator = ((Button)sender).Text[0];
                    dblResult = double.Parse(textBox1.Text);
                    HistoryText += dblResult.ToString();
                }
                else if (isNewEntry)
                {
                    HistoryText = string.Empty;
                    HistoryText += dblResult.ToString();
                    chPreviousOperator = ((Button)sender).Text[0];
                }
                else if(isContOperand == true)
                {
                    HistoryText += textBox1.Text;
                    chPreviousOperator = ((Button)sender).Text[0];
                    Operate(dblResult, chPreviousOperator, double.Parse(textBox1.Text));
                }
            else if(isContOperation == true)
            {
                dblResult = 0;
                HistoryText += textBox1.Text;
                Operate(dblResult, chPreviousOperator, double.Parse(textBox1.Text));
            }
                isNewEntry = true;
                isNextOperation = false;
                isRepeatLastOperation = false;
                HistoryText += chPreviousOperator; 
            }
        }
        
        // Doing different Operations
        private void Operate(double dblPreviousResult, char chPreviousOperator, double dblOperand)
        {
            switch(chPreviousOperator)
            {
                
                case '+':
                    textBox1.Text = (dblResult = (dblPreviousResult + dblOperand)).ToString();
                    break;
                case '-':
                    textBox1.Text = (dblResult = (dblPreviousResult - dblOperand)).ToString();
                    break;
                case '*':
                    textBox1.Text = (dblResult = (dblPreviousResult * dblOperand)).ToString();
                    break;
                case '/':
                    if (dblOperand == 0)
                    {
                        MessageBox.Show("An error has occured", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                        //textBox1.Text = "0";
                        //isInfinityException = true;
                    }
                    else
                        textBox1.Text = (dblResult = (dblPreviousResult / dblOperand)).ToString();
                    break; 
            }
        }

        //Operation for Equal button
        private void btnEqual_Click(object sender, EventArgs e)
        {
            
            if(!isInfinityException)
            {
                if(!isRepeatLastOperation)
                {
                    dblOperand = double.Parse(textBox1.Text);
                    HistoryText += dblOperand.ToString();
                    Operate(dblResult, chPreviousOperator, dblOperand);
                    textBox1.Text = dblResult.ToString();
                    isRepeatOperation = false;
                    isNewEntry = true;
                    isNextOperation = true;
                }

                if (isRepeatOperation == true)
                {
                    HistoryText = string.Empty;
                    Num1 = dblResult;
                    HistoryText += dblResult.ToString();
                    HistoryText += chPreviousOperator.ToString();
                    HistoryText += dblOperand.ToString();
                    Operate(dblResult, chPreviousOperator, dblOperand);
                    textBox1.Text = dblResult.ToString();
                    isRepeatOperation = true;
                    isNewEntry = true;
                }
            }

            //Operation to save Data and to show dialog box
            if (dblOperand != 0)
            {
                if (isPressedNo == true)
                {
                    DialogResult DR = MessageBox.Show("1: To Save, Press = YES. \n2: Do Not Save, Press = NO", "Save Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DR == DialogResult.No)
                    {
                        isPressedYes = false;
                    }
                }
                if (isPressedYes != true)
                {
                    DialogResult DR = MessageBox.Show("1: To Save, Press = YES. \n2: Do Not Save, Press = NO", "Save Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DR == DialogResult.Yes)
                    {
                        if (!isPressedYes)
                        {
                            string path = "..//..//SaveData.txt";
                            Button button = (Button)sender;
                            StreamWriter streamWriter = new StreamWriter(path);
                            streamWriter.WriteLine(HistoryText + button.Text + dblResult.ToString());
                            isRepeatLastOperation = true;
                            isRepeatOperation = true;
                            isPressedYes = true;
                            isPressedNo = false;
                            
                            try
                            {
                                if (isSaveAgain == false)
                                {
                                    streamWriter.Close();
                                    isSaveAgain = true;
                                }
                                else
                                {
                                    streamWriter.Close();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    string path = "..//..//SaveData.txt";
                    try
                    {
                        if (isSaveAgain == false)
                        {
                            StreamWriter streamWriter = new StreamWriter(path);
                            streamWriter.WriteLine(HistoryText + "=" + dblResult.ToString());
                            streamWriter.Close();
                            isSaveAgain = true;
                        }
                        else
                        {
                            StreamWriter streamWriter = new StreamWriter(path, true);
                            streamWriter.WriteLine(HistoryText + "=" + dblResult.ToString());
                            textBox1.Text = dblResult.ToString();
                            streamWriter.Close();
                            isNextOperation = true;
                            isContOperation = true;
                            isRepeatOperation = true;
                            isRepeatLastOperation = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                } 
            }
        }

        //Creating a Button press Event
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                    btn0.Focus();
                    btn0.PerformClick();
                    break;
                case '1':
                    btn1.Focus();
                    btn1.PerformClick();
                    break;
                case '2':
                    btn2.Focus();
                    btn2.PerformClick();
                    break;
                case '3':
                    btn3.Focus();
                    btn3.PerformClick();
                    break;
                case '4':
                    btn4.Focus();
                    btn4.PerformClick();
                    break;
                case '5':
                    btn5.Focus();
                    btn5.PerformClick();
                    break;
                case '6':
                    btn6.Focus();
                    btn6.PerformClick();
                    break;
                case '7':
                    btn7.Focus();
                    btn7.PerformClick();
                    break;
                case '8':
                    btn8.Focus();
                    btn8.PerformClick();
                    break;
                case '9':
                    btn9.Focus();
                    btn9.PerformClick();
                    break;
                case '.':
                    btnDecimalPoint.Focus();
                    btnDecimalPoint.PerformClick();
                    break;
                case '+':
                    btnAdd.Focus();
                    btnAdd.PerformClick();
                    break;
                case '-':
                    btnSub.Focus();
                    btnSub.PerformClick();
                    break;
                case '*':
                    btnMul.Focus();
                    btnMul.PerformClick();
                    break;
                case '/':
                    btnDiv.Focus();
                    btnDiv.PerformClick();
                    break;
                case (char)Keys.Escape:
                    btnAclr.Focus();
                    btnAclr.PerformClick();
                    break;
                default:
                    break;
            }
        }
        //Creating a Function for Focus, EnterKey, DeleteKey
        protected override bool ProcessCmdKey(ref Message message, Keys keyValue)
        {
            string Data = this.ActiveControl.Text;

            if (keyValue == Keys.Enter || keyValue == Keys.Delete ||
                keyValue == Keys.Down || keyValue == Keys.Up)
            {
                ArrayKeyPress(keyValue, Data);

                if (keyValue == Keys.Enter)
                {
                    btnEqual.Focus();
                    btnEqual.PerformClick();
                }
                if (keyValue == Keys.Delete)
                {
                    btnPClr.Focus();
                    btnPClr.PerformClick();
                }
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref message, keyValue);
            }
        }

        private void ArrayKeyPress(Keys UpOrDown, string buttonText)
        {
            if (UpOrDown == Keys.Down)
            {
                switch (buttonText)
                {
                    case "7":
                        btn4.Focus();
                        break;
                    case "4":
                        btn1.Focus();
                        break;
                    case "1":
                        btn0.Focus();
                        break;
                    case "8":
                        btn5.Focus();
                        break;
                    case "5":
                        btn2.Focus();
                        break;
                    case "2":
                        btn0.Focus();
                        break;
                    case "9":
                        btn6.Focus();
                        break;
                    case "6":
                        btn3.Focus();
                        break;
                    case "3":
                        btnDecimalPoint.Focus();
                        break;
                    case "/":
                        btnMul.Focus();
                        break;
                    case "*":
                        btnSub.Focus();
                        break;
                    case "-":
                        btnAdd.Focus();
                        break;
                    case "CE":
                        btnAclr.Focus();
                        break;
                    case "C":
                        btnEqual.Focus();
                        break;

                    default:
                        break;
                }
            }

            if (UpOrDown == Keys.Up)
            {
                switch (buttonText)
                {
                    case "0":
                        btn1.Focus();
                        break;
                    case "1":
                        btn4.Focus();
                        break;
                    case "4":
                        btn7.Focus();
                        break;
                    case "2":
                        btn5.Focus();
                        break;
                    case "5":
                        btn8.Focus();
                        break;
                    case ".":
                        btn3.Focus();
                        break;
                    case "3":
                        btn6.Focus();
                        break;
                    case "6":
                        btn9.Focus();
                        break;
                    case "+":
                        btnSub.Focus();
                        break;
                    case "-":
                        btnMul.Focus();
                        break;
                    case "*":
                        btnDiv.Focus();
                        break;
                    case "=":
                        btnAclr.Focus();
                        break;
                    case "C":
                        btnPClr.Focus();
                        break;

                    default:
                        break;
                }

            }
        }

        //Performing the Drag and Drop Operation
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] DropText = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var text in DropText)
            {
                string FilePath = GetDropFilePath(text);
                string fileExtension = Path.GetExtension(FilePath).ToLower();
                if (fileExtension == ".txt")
                {
                    if (FilePath != null)
                    {
                        string readerText = File.ReadAllText(FilePath);
                        char[] readerTextChar = readerText.ToCharArray();
                        char[] CalcualtorAcceptNumber = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '.', '+', '-', '/', '*', (char)13, (char)10 };

                        foreach (var textChar in readerTextChar)
                        {
                            if (CalcualtorAcceptNumber.Contains(textChar))
                            {
                                switch (textChar)
                                {
                                    //Numbers(0-9)
                                    case '0':
                                        btn0.PerformClick();
                                        break;

                                    case '1':
                                        btn1.PerformClick();
                                        break;

                                    case '2':
                                        btn2.PerformClick();
                                        break;

                                    case '3':
                                        btn3.PerformClick();
                                        break;

                                    case '4':
                                        btn4.PerformClick();
                                        break;

                                    case '5':
                                        btn5.PerformClick();
                                        break;

                                    case '6':
                                        btn6.PerformClick();
                                        break;

                                    case '7':
                                        btn7.PerformClick();
                                        break;

                                    case '8':
                                        btn8.PerformClick();
                                        break;
                                    case '9':
                                        btn9.PerformClick();
                                        break;
                                    //Different Operators
                                    case '.':
                                        btnDecimalPoint.PerformClick();
                                        break;
                                    case '+':
                                        btnAdd.PerformClick();
                                        break;

                                    case '-':
                                        btnSub.PerformClick();
                                        break;

                                    case '*':
                                        btnMul.PerformClick();
                                        break;

                                    case '/':
                                        btnDiv.PerformClick();
                                        break;

                                    //(char)10='/r'
                                    case (char)13:
                                        break;

                                    //(char)10='/n'
                                    case (char)10:
                                        break;

                                    default:
                                        break;
                                }
                            }
                            else
                            {
                                DialogResult messageButton = MessageBox.Show("Entered Texts in textfile are invalid", "Invalid Character", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                if (messageButton == DialogResult.OK)
                                {
                                    btnAclr.PerformClick();

                                }
                                return;
                            }
                        }
                        //isDragAndDrop = true;
                        btnEqual.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show(" Please Drag and Drop the '.txt' file ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private string GetDropFilePath(string path)
        {
            return Path.GetFullPath(path);
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
    }
}
