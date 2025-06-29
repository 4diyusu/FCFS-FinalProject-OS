using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProgTestingPhase___Zacal
{
    public partial class FCFS : Form
    {
        Queue<string> consultationQueue = new Queue<string>();
        Queue<string> laboratoryQueue = new Queue<string>();
        Queue<string> vaccinationQueue = new Queue<string>();
        Queue<string> billingQueue = new Queue<string>();

        int consultationCount = 1;
        int laboratoryCount = 1;
        int vaccinationCount = 1;
        int billingCount = 1;

        public FCFS()
        {
            InitializeComponent();
        }

        //Consultation
        private void btnAddConsultation_Click(object sender, EventArgs e)
        {
            string person = "Consultation #" + consultationCount++;
            consultationQueue.Enqueue(person);
            listConsultation.Items.Add(person);
        }

        private void btnNxtConsultation_Click(object sender, EventArgs e)
        {
            if (consultationQueue.Count > 0)
            {
                string serving = consultationQueue.Dequeue();
                lblConsultation.Text = "Now Serving: " + serving;
                listConsultation.Items.RemoveAt(0);
            }
            else
            {
                lblConsultation.Text = "Now Serving: None";
            }
        }

        //Laboratory
        private void btnAddLaboratory_Click(object sender, EventArgs e)
        {
            string person = "Laboratory #" + laboratoryCount++;
            laboratoryQueue.Enqueue(person);
            listLaboratory.Items.Add(person);
        }

        private void btnNxtLaboratory_Click(object sender, EventArgs e)
        {
            if (laboratoryQueue.Count > 0)
            {
                string serving = laboratoryQueue.Dequeue();
                lblLaboratory.Text = "Now Serving: " + serving;
                listLaboratory.Items.RemoveAt(0);
            }
            else
            {
                lblLaboratory.Text = "Now Serving: None";
            }
        }

        //Vaccination
        private void btnAddVaccination_Click(object sender, EventArgs e)
        {
            string person = "Vaccination #" + vaccinationCount++;
            vaccinationQueue.Enqueue(person);
            listVaccination.Items.Add(person);
        }

        private void btnNxtVaccination_Click(object sender, EventArgs e)
        {
            if (vaccinationQueue.Count > 0)
            {
                string serving = vaccinationQueue.Dequeue();
                lblVaccination.Text = "Now Serving: " + serving;
                listVaccination.Items.RemoveAt(0);
            }
            else
            {
                lblVaccination.Text = "Now Serving: None";
            }
        }

        //Billing
        private void btnAddBilling_Click(object sender, EventArgs e)
        {
            string person = "Billing #" + billingCount++;
           billingQueue.Enqueue(person);
            listBilling.Items.Add(person);
        }

        private void btnNxtBilling_Click(object sender, EventArgs e)
        {
            if (billingQueue.Count > 0)
            {
                string serving = billingQueue.Dequeue();
                lblBilling.Text = "Now Serving: " + serving;
                listBilling.Items.RemoveAt(0);
            }
            else
            {
                lblBilling.Text = "Now Serving: None";
            }
        }
    }
}
