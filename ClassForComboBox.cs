namespace jenya_lab_7
{
    public class ClientForCombox
    {
        public string idClient { get; set; }
        public string nameClient { get; set; }

        public override string ToString()
        {
            return nameClient;
        }
    }
    public class SpecialistForCombox
    {
        public string idSpecialist { get; set; }
        public string nameSpecialist { get; set; }
        public override string ToString()
        {
            return nameSpecialist;
        }

    }
}
