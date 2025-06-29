namespace FinalProgTestingPhase___Zacal
{
    public partial class Form1 : Form
    {
        Queue<string> registrarQueue = new Queue<string>();
        Queue<string> scholarshipQueue = new Queue<string>();
        Queue<string> treasuryQueue = new Queue<string>();
        Queue<string> helpDeskQueue = new Queue<string>();

        int registrarCount = 1;
        int scholarshipCount = 1;
        int treasuryCount = 1;
        int helpDeskCount = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddRegistrar_Click(object sender, EventArgs e)
        {
            string person = "Registrar #" + registrarCount++;
            registrarQueue.Enqueue(person);
            lstRegistrar.Items.Add(person);
        }

        private void btnNextRegistrar_Click(object sender, EventArgs e)
        {
            if (registrarQueue.Count > 0)
            {
                string serving = registrarQueue.Dequeue();
                lblRegistrarServing.Text = "Now Serving: " + serving;
                lstRegistrar.Items.RemoveAt(0);
            }
            else
            {
                lblRegistrarServing.Text = "Now Serving: None";
            }
        }

        private void btnAddTreasury_Click(object sender, EventArgs e)
        {
            string person = "Treasury #" + treasuryCount++;
            treasuryQueue.Enqueue(person);
            lstTreasury.Items.Add(person);
        }

        private void btnNextTreasury_Click(object sender, EventArgs e)
        {
            if (treasuryQueue.Count > 0)
            {
                string serving = treasuryQueue.Dequeue();
                lblTreasuryServing.Text = "Now Serving: " + serving;
                lstTreasury.Items.RemoveAt(0);
            }
            else
            {
                lblTreasuryServing.Text = "Now Serving: None";
            }
        }

        private void btnAddScholarship_Click(object sender, EventArgs e)
        {
            string person = "Scholarship #" + scholarshipCount++;
            scholarshipQueue.Enqueue(person);
            lstScholarship.Items.Add(person);
        }

        private void btnNextScholarship_Click(object sender, EventArgs e)
        {
            if (scholarshipQueue.Count > 0)
            {
                string serving = scholarshipQueue.Dequeue();
                lblScholarshipServing.Text = "Now Serving: " + serving;
                lstScholarship.Items.RemoveAt(0);
            }
            else
            {
                lblScholarshipServing.Text = "Now Serving: None";
            }
        }

        private void btnAddHelpDesk_Click(object sender, EventArgs e)
        {
            string person = "Help Desk #" + helpDeskCount++;
            helpDeskQueue.Enqueue(person);
            lstHelpDesk.Items.Add(person);
        }

        private void btnNextHelpDesk_Click(object sender, EventArgs e)
        {
            if (helpDeskQueue.Count > 0)
            {
                string serving = helpDeskQueue.Dequeue();
                lblHelpDeskServing.Text = "Now Serving: " + serving;
                lstHelpDesk.Items.RemoveAt(0);
            }
            else
            {
                lblHelpDeskServing.Text = "Now Serving: None";
            }
        }

        private void lblTreasuryServing_Click(object sender, EventArgs e)
        {

        }
    }
}
