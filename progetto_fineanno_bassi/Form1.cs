namespace progetto_fineanno_bassi
{
    public partial class Form1 : Form
    {
        MyList stringhe = new MyList();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           


            //Console.WriteLine("Inserisci una stringa (digita 'exit' per uscire):");
            string nota = textBox1.Text;

                

                DateTime ora = DateTime.Now;
                string messaggio = $"{ora}: {nota}";
                stringhe.AddTail(messaggio);

               label1.Text = stringhe.ToString();
            //MessageBox.Show(stringhe.ToString());
            //Console.WriteLine("Stringhe inserite:");
            //Console.WriteLine(stringhe);
            //label1.Text = stringhe.ToString();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}