using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamlaDB
{
    internal class szamlak
    {
        int id;
        string tulajNev;
        decimal egyenleg;
        MySqlDateTime nyitas;

        public int Id { get => id; set => id = value; }
        public string TulajNev { get => tulajNev; set => tulajNev = value; }
        public decimal Egyenleg { get => egyenleg; set => egyenleg = value; }
        public MySqlDateTime Nyitas { get => nyitas; set => nyitas = value; }

        public szamlak(int id, string tulajNev, decimal egyenleg, MySqlDateTime nyitas)
        {
            Id = id;
            TulajNev = tulajNev;
            Egyenleg = egyenleg;
            Nyitas = nyitas;
        }

        public override string ToString()
        {
            return $"{tulajNev}: {egyenleg}";
        }
    }
}
