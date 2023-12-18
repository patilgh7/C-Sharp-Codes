using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RealTimeExampleQueue
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["TokenQueue"] == null)
            {
                Queue<int> queueTokens = new Queue<int>();
                Session["TokenQueue"] = queueTokens;
            }
            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void btnCounter2_Click(object sender, EventArgs e)
        {

        }

        protected void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtDisplay_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void btnPrintToken_Click(object sender, EventArgs e)
        {
            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];

            lblStatus.Text = "There are " + tokenQueue.Count.ToString() + " customers before you in the queue";

            if (Session["LastTokenNumberIssued"] == null)
            {
                Session["LastTokenNumberIssued"] = 0;
            }

            int nextTokenNumberTobeIssued = (int)Session["LastTokenNumberIssued"] + 1;

            Session["LastTokenNumberIssued"] = nextTokenNumberTobeIssued;

            tokenQueue.Enqueue(nextTokenNumberTobeIssued);

            AddTokensToListBox(tokenQueue);

        }

        private void AddTokensToListBox(Queue<int> tokenQueue)
        {
            listTokens.Items.Clear();

            foreach (int token in tokenQueue)
            {
                listTokens.Items.Add(token.ToString());
            }
        }

        private void ServerNextCustomer(TextBox textBox , int counterNumber)
        {
            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];

            if (tokenQueue.Count == 0)
            {
                textBox.Text = "No customers in the queue";
            }
            else
            {
                int tokenNumberToBeServed = tokenQueue.Dequeue();

                textBox.Text = tokenNumberToBeServed.ToString();

                txtDisplay.Text = "Token Number : " + tokenNumberToBeServed.ToString() + 
                    " Please go to counter "+counterNumber.ToString();

                AddTokensToListBox(tokenQueue);
            }
        }
        protected void btnCounter1_Click(object sender, EventArgs e)
        {
            /*
             *  // Below code is same for both btnCounter2_Click1 and btnCounter3_Click method
                // So we can make below code seperate method for reusability purpose => ServerNextCustomer()
                    Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];

                    if (tokenQueue.Count == 0)
                    {
                        txtCounter1.Text = "No customers in the queue";
                    }
                    else
                    {
                        int tokenNumberToBeServed = tokenQueue.Dequeue();

                        txtCounter1.Text = tokenNumberToBeServed.ToString();

                        txtDisplay.Text = "Token Number : " + tokenNumberToBeServed.ToString() + 
                            "Please go to counter 1";

                        AddTokensToListBox(tokenQueue);
                    }
             */


            ServerNextCustomer(txtCounter1, 1);

        }

        protected void btnCounter2_Click1(object sender, EventArgs e)
        {
            ServerNextCustomer(txtCounter2, 2);
        }

        protected void btnCounter3_Click(object sender, EventArgs e)
        {
            ServerNextCustomer(txtCounter3 , 3);
        }
    }
}