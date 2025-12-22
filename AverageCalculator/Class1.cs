namespace AverageCalculator 
{
    public class Calculator
    {
        private double[] list;
        private int length;
        private int count_changes = 0;
        private int memory;

        private void Setlength() {
            length = list.Length;
        }

        private void Setmemorytozero() {
            this.memory = 0;
        }

        public void Add(double value) {
            Setlength();
            if(memory > length) {
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

        public void Add(double[] values) {
            if(values.Length <= 0) {
                throw new ArgumentException("Error: Length of the is out of bounce of the array");
            } else {
                Setlength();
                for(int count = 0; count < length; count++) {
                    list[count] = values[count];
                    count_changes++;
                memory++;
                }   
            }
        }

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

        public int Count() {
            return count_changes;
        }

        public Calculator(double[] new_list){
            list = new_list;
        }
    }
}
