namespace InterfacciaElenco
{
    class VettoreDinamico : IElenco
    {
        string[] vettore;
        int count;
        int length;

        public VettoreDinamico()
        {
            count = 0;
            length = 1;
            vettore = new string[length];
        }

        public int Count => count;

        public int Length => length;

        public void Add(string item)
        {
            vettore[count] = item;
            count++;
            if (count == length)
            {
                string[] newVettore = new string[length * 2];
                for (int i = 0; i < length; i++)
                {
                    newVettore[i] = vettore[i];
                }
                vettore = newVettore;
                length *= 2;
            }
        }

        public string GetItemAt(int index)
        {
            if (index > -1)
            {
                if (index < length)
                {
                    if (vettore[index] == null)
                    {
                        return $"L'elemento alla posizione {index} è null";
                    }
                    else return vettore[index];
                }
                else return "L'indice è maggiore dell'indice massimo del vettore";
            }
            return "L'indice non può essere un valore negativo";
        }

        public void Remove(string item)
        {
            for (int i = 0; i < length; i++)
            {
                if (vettore[i] == item)
                {
                    vettore[i] = null;
                }
            }
            ShiftAndDivide();
        }

        public void RemoveAt(int index)
        {
            // rimozione elemento
            vettore[index] = null;
            ShiftAndDivide();
        }

        private void ShiftAndDivide()
        {
            // shift
            string[] vettoreShift = new string[length];
            for (int i = 0; i < length; i++)
            {
                vettoreShift[i] = vettore[(i + 1) % length];
            }
            vettore = vettoreShift;
            // divisione del vettore
            if (count < (length / 2))
            {
                string[] tempVettore = new string[length / 2];
                for (int i = 0; i < length / 2; i++)
                {
                    tempVettore[i] = vettore[i];
                }
                vettore = tempVettore;
            }
        }
    }
}
