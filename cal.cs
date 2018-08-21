    public double SUM_ArrayPrice(var[] Array_Var)
        {
            double[] testDoubleArray;
            double resultDouble;
            for (int i = 0; i < testDoubleArray.length; i++)
            {
                returnDouble += testDoubleArray[i];
            }
            return resultDouble;
            
            //Array_Var.length
        }

        public AVG_ArrayPirce(double sum_price, int DAY)
        {
            return sum_price/DAY;
        }
        public SM(double SUM_ArrayPrice, int DAY)
        {
            return AVG_ArrayPirce/DAY;
        }
        public D1(double M, double SM, int DAY)
        {
            return M-SM/DAY;
        }

        public D2(var[] Array_Var)
        {
            return SUM_ArrayPrice(Array_Var);
        }

        public RESULT(double M, double SM, double D2)
        {
            return (M-SM)/(0.015*D2);
        }
