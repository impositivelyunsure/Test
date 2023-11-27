using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
// Ethan Daly, Astronomically Hopeless, Sprint 1
// Date: 24/06/23
// Version: 1
// Name of Program: Astronomical Processing
// Program is to store astronomical neutrinos. Has functionality to sort, search and edit values.
// One text box used to search and edit data. Search button uses binary search algorithm. Sort button used bubble sort algorithm. Edit button edits a selected value.
namespace AstronomicalProcessing
{
    public partial class Form1 : Form
    {
        int ptr = 0;
        const int max = 24;
        int[] arrayNeutrinos = new int[max];
        int mode = 0;
        int mid = 0;
        int range = 0;
        float avg = 0;
        float sum = 0;

        public Form1()
        {
            InitializeComponent();
            PopulateArray();
            BubbleSort();
            DisplayArray();



        }

        // list box selected index change
        private void listBoxNeutrinos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if there is a selected index
            if (!(listBoxNeutrinos.SelectedIndex == -1))
            {
                txtBoxNeut.Text = listBoxNeutrinos.SelectedItem.ToString();
            }
            else
            {


            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // if there is not a selected index and there the text box contains empty, null or white space 
            if (!(listBoxNeutrinos.SelectedIndex == -1) && (string.IsNullOrEmpty(txtBoxNeut.Text)) || (string.IsNullOrEmpty(txtBoxNeut.Text)))
            {
                MessageBox.Show("Index selection error, or value contains empty, null or white space.", "Data Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                arrayNeutrinos[listBoxNeutrinos.SelectedIndex] = Int32.Parse(txtBoxNeut.Text);
                BubbleSort();
                DisplayArray();
                ClearTextBox();
            }
        }

        // button bubble sort method
        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            BubbleSort();
            ClearTextBox();
            DisplayArray();
        }
        // button binary search method
        private void btnBinarySearch_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtBoxNeut.Text) || string.IsNullOrWhiteSpace(txtBoxNeut.Text)))
            {
                int input = Int32.Parse(txtBoxNeut.Text);
                int foundValue = BinarySearch(arrayNeutrinos, input);
                if (foundValue != -1)
                {
                    listBoxNeutrinos.SelectedIndex = foundValue - 1;
                    MessageBox.Show("Found " + input + " at index " + foundValue, "Found Searched Value", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Could not find value", "Failed to Find Searched Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxNeut.Focus();
                }
                BubbleSort();
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("Input is empty, null or white space", "Failed to Find", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAverge_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < max; i++)
            {
                sum += arrayNeutrinos[i];
                avg = sum / arrayNeutrinos.Length;
                if (i >= max - 1)
                {
                    txtBoxCalc.Text = avg.ToString(".00");
                    MessageBox.Show("Average is " + avg, "Average Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnRange_Click(object sender, EventArgs e)
        {
            range = arrayNeutrinos.LastOrDefault() - arrayNeutrinos.FirstOrDefault();
            MessageBox.Show("Range is " + range, "Range Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtBoxCalc.Text = range.ToString(".00");
        }

        private void btnSeqSearch_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtBoxCalc.Text) || string.IsNullOrWhiteSpace(txtBoxCalc.Text)))
            {
                int input = Int32.Parse(txtBoxCalc.Text);
                int foundValue = SequentialSearch(arrayNeutrinos, input);
                if (foundValue != -1)
                {
                    MessageBox.Show("Found value: " + foundValue, "Successfully Found Value", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Could not find value", "Failed to Find Searched Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxNeut.Focus();
                }
                BubbleSort();
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("Input is empty, null or white space", "Failed to Find", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnMode_Click(object sender, EventArgs e)
        {
            List<Int32> multipleValues = new List<Int32>();

            // my own solution, doesn't work on un-sorted values.
            // Explanation:
            // Loop inside the parameters of the array, excluding the first and last index. (Actual list size: 24 | We loop through: 1 to 23)
            // First comparison statement checks if the index's value before and after your current position in the array are the same:
            // selected indexs of the array:
            // 0 [1] 2 3 4 5 6 7..
            // values of indexes in array:
            // 11, [11], 55, 64, 43, 13, 13
            // Is the previous value or subsequent value the same as your current position in the list? If yes, add the current index's value to the list
            // Second and third comparison statement checks if you are at the start or end of the list, and if the previous or subsequent value is a duplicate
            // of your current position.
            for (int i = 1; i < max - 1; i++)
            {
                // identify the number of multiple multiple values
                // operates within parameters of 1 through to 23, checking if the previous or next value in the array is the same
                // if value at index one before, or after your current position in the array is the same, add duplicate value to list
                if (arrayNeutrinos[i] == arrayNeutrinos[i - 1] || arrayNeutrinos[i] == arrayNeutrinos[i + 1])
                {
                    multipleValues.Add(arrayNeutrinos[i]);
                    // makes sure the value at the start of array and end of array is properly handled, otherwise only one duplicate would be added. explanation:

                    // first if expression is true (values at index at 0 and 1 are the same), so add dupe value and continue, effectively not adding the other dupe value 
                    // because the next iteration never evaluates first or last value of array again. same logic for when you reach the length - 1 of the array. So this
                    // extra logic is needed. Only solution I could think of to avoid throwing an index out of bounds exception.
                    if (i == 1 || i == 22)
                    {
                        if (arrayNeutrinos[i] == arrayNeutrinos[i - 1] || arrayNeutrinos[i] == arrayNeutrinos[i + 1])
                        {
                            multipleValues.Add(arrayNeutrinos[i]);
                        }
                    }
                }
            }
            // This LINQ solution and retrieves the mode of the already found modes in the list to demonstrate a more concise approach to this solution

            if (multipleValues.Count > 0)
            {
                mode = multipleValues.GroupBy(v => v) // place all identical values into groups
                    .OrderByDescending(g => g.Count()) // order groups by the size of the group 
                    .Select(g => g.Key) // key of the group is representative of items in group
                    .First(); //  // retrieve most frequent modal value
                txtBoxCalc.Text = mode.ToString();
                MessageBox.Show("Mode: " + mode, "Successfully calculated mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("There are no repeating values in the list", "Failed to Calculate Mode", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxNeut.Focus();
            }
        }

        private void btnMid_Click(object sender, EventArgs e)
        {
            mid = arrayNeutrinos.Length / 2;
            listBoxNeutrinos.SelectedIndex = mid;
            txtBoxCalc.Text = listBoxNeutrinos.SelectedItem.ToString();
            txtBoxNeut.Clear();
        }

        public static int SequentialSearch(int[] arrayNeutrinos, int key)
        {
            for (int i = 0; i < max; i++)
            {
                if (arrayNeutrinos[i] == key)
                {
                    int value = arrayNeutrinos[i];
                    return value;
                }
            }
            return -1;
        }

        // bubble sort method
        public void BubbleSort()
        {
            var n = arrayNeutrinos.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arrayNeutrinos[j] > arrayNeutrinos[j + 1])
                    {
                        var tempVar = arrayNeutrinos[j];
                        arrayNeutrinos[j] = arrayNeutrinos[j + 1];
                        arrayNeutrinos[j + 1] = tempVar; ;
                    }
                }
            }
        }

        // Method to populate the array with random numbers from 10 to 99
        public void PopulateArray()
        {
            var rand = new Random();
            for (int i = 0; i < max; i++)
            {
                arrayNeutrinos[i] += rand.Next(10, 100);
            }
        }

        // Method to clear the text box
        public void ClearTextBox()
        {
            txtBoxNeut.Clear();
        }

        // Method to display the list box with values from the neutrino array
        public void DisplayArray()
        {
            listBoxNeutrinos.Items.Clear();
            for (int i = 0; i < max; i++)
            {
                listBoxNeutrinos.Items.Add(arrayNeutrinos[i]);
            }
        }
        // Method to binary search the array
        public static int BinarySearch(int[] arrayNeutrinos, int key)
        {
            int min = 0;
            int max = arrayNeutrinos.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == arrayNeutrinos[mid])
                {
                    return ++mid;
                }
                else if (key < arrayNeutrinos[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }

        // not implemented in end result, used for testing
        // repopulates list with new set of random numbers
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < max; i++)
            {
                arrayNeutrinos[i] = 0;
            }
            listBoxNeutrinos.Items.Clear();
            PopulateArray();
            BubbleSort();
            DisplayArray();

        }

    }
}