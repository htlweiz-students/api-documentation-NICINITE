namespace AverageCalculator 
{
    /// <summary>
    /// Calculates the arithemetic number of a added value
    /// or added list and counts every changes.
    /// </summary>
    public class Average
    {
        private double[] list;
        private int length;
        private int count_changes = 0;
        private int memory;

        private void Setlength() {
            if(list.Length <= 0) {
                throw new ArgumentException("Error: Length of the is Zero!");
            }
            length = list.Length;
        }

        private void Setmemorytozero() {
            this.memory = 0;
        }

        /// <summary>
        /// Adds a double value in the Object.
        /// </summary>
        /// <param name="value">the number that's going to be added</param>
        /// <param name="count_changes">counts every change</param>
        public void Add(double value) {
            Setlength();
            if(memory == length) {
                Setmemorytozero();
            }

            for(int count = 0; count < length; count++) {
                if(count == memory) {
                    list[count] = value;
                }
            }

            memory++;            
            count_changes++;
        }

        /// <summary>
        /// Adds a double array in the Object.
        /// </summary>
        /// <param name="values">the numbers that are going to be added</param>
        /// <param name="count_changes">counts every change</param>
        public void Add(double[] values) {
            Setlength();
            for(int count = 0; count < length; count++) {
                list[count] = values[count];
                count_changes++;
                memory++;
            }   
        }

        /// <summary>
        /// Calculates the arrithmetic number of the given values and returns it
        /// </summary>
        /// <param name="sum">sum of all numbers in the array</param>
        /// <param name="arithmetic">variable for the arithmetic value</param>
        public double GetAverage() {
            double arithmetic;
            double sum = 0;

            for(int count = 0; count < length; count++) {
                sum += list[count]; 
            }
            arithmetic = sum / list.Length;
            return arithmetic;
        }

        public double[] GetElements() {
            return list;
        }

        /// <summary>
        /// Returns every changes
        /// </summary>
        /// <param name="count_changes">changes saved in a variable</param>
        public int Count() {
            return count_changes;
        }

        /// <summary>
        /// Is the constructor that sets the list field
        /// </summary>
        /// <param name="list">field of the class</param>
        /// <param name="new_list">value for the new added array</param>
        public Average(double[] new_list){
            list = new_list;
        }
    }
}
