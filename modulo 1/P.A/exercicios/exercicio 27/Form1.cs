namespace Ex27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool StringNumerica(string str, string tipoDeDado, bool assinado)
        {
            if (!assinado)
            {
                if (str[0] == '-')
                    return false;
            }

            if (str == "" || str == "," || str == "-")
                return false;

            if (tipoDeDado == "decimal")
            {
                int virgulas = 0;
                int i = 0;
                foreach (char c in str)
                {
                    if (c.Equals(',') || (c.Equals('-') && i == 0))
                    {
                        if (c.Equals(','))
                        {
                            virgulas++;
                            if (virgulas > 1)
                                return false;
                        }
                    }
                    else
                    {
                        if (char.IsDigit(c) == false)
                            return false;
                    }
                    i++;
                }
                return true;
            }

            if (tipoDeDado == "int")
            {
                int i = 0;
                foreach (char c in str)
                {
                    if (!(c.Equals('-') && i == 0))
                    {
                        if (char.IsDigit(c) == false)
                            return false;
                    }
                    i++;
                }
                return true;
            }
            return false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            labResult.Visible = false;
            foreach (Control txb in this.Controls)
            {
                if (txb.GetType() == typeof(TextBox))
                    txb.Text = "";
            }

            foreach (Control lab in this.Controls)
            {
                if (lab.GetType() == typeof(Label))
                    lab.ForeColor = SystemColors.ControlText;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            foreach (Control lab in this.Controls)
            {
                if (lab.GetType() == typeof(Label))
                    lab.ForeColor = SystemColors.ControlText;
            }

            var textboxes = this.Controls.OfType<TextBox>();
            bool tudoCerto = true;
            
            foreach (TextBox txb in textboxes)
            {
                if(!StringNumerica(txb.Text, "int", true))
                {
                    string i = "";
                    foreach(char c in txb.Name)
                    {
                        if (char.IsDigit(c))
                            i += c;
                    }
                    var labsComErro = this.Controls.Find("labNum" + i, true);
                    foreach (Label l in labsComErro)
                        l.ForeColor = Color.Red;

                    tudoCerto = false;
                }
               
            }

            if (tudoCerto)
            {
                int[] nums = new int[20];
                int menor, maior;
                
                int i = 0;
                foreach (Control txb in this.Controls)
                {
                    if (txb.GetType() == typeof(TextBox)) 
                    { 
                        nums[i] = (Convert.ToInt32(txb.Text));
                        i++;
                    }
                }

                menor = nums[0];
                maior = nums[0];

                foreach (int num in nums)
                {
                    if(num > maior)
                        maior = num;
                    if (num < menor)
                        menor = num;
                }

                labResult.Text = $"Maior: {maior}   Menor: {menor}";                
                labResult.Visible = true;
            } 
            
        }
    }
}
