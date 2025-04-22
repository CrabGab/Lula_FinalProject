using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /* Ethan's problem 42 below */
        protected void btnShowSolution_Click(object sender, EventArgs e)
        {
            var problem = new LeetsCodeProblem42();

            int[] test1 = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            int[] test2 = { 4, 2, 0, 3, 2, 5 };

            lblDescription.Text = problem.GetDescription();
            lblTestCase1.Text = "Test Case 1: [0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]";
            lblResult1.Text = "Output: " + problem.Solve(test1);
            lblTestCase2.Text = "Test Case 2: [4, 2, 0, 3, 2, 5]";
            lblResult2.Text = "Output: " + problem.Solve(test2);
        }
        /* Gabe's problem 1028 below */
        protected void btnShowSolution1028_Click(object sender, EventArgs e)
        {
            var problem = new Lula_FinalProject.LeetCodeProblem1028();

            lblDescription1028.Text = "LeetCode 1028 - Recover a Tree From Preorder Traversal";
            lblTestCase1028.Text = "Test Case: \"1-2--3--4-5--6--7\"";
            lblResult1028.Text = "Output (In-Order Traversal): " + problem.SolveExample();
        }

    }
}