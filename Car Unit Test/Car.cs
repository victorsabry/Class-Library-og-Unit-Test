namespace Car_Unit_Test
{
    public class Car
    {
        public int Id { get; set; }
        public string? Model { get; set; }
        public int Price { get; set; }
        public string? LicensePlate { get; set; }


        public void ValidateModel()
        {
            if (Model == null || Model.Length < 4)
            {
                throw new ArgumentOutOfRangeException($"Model name needs to be at least 4 characters long");
            }
        }

        public void ValidatePrice()
        {
            if (Price <= 0)
            {
                throw new ArgumentOutOfRangeException($"Price can't be less than zero, your price was {Price}");
            }
        }

        public void ValidateLicensePlate()
        {
            if (LicensePlate.Length < 2 || LicensePlate.Length > 7)
            {
                throw new ArgumentOutOfRangeException($"Invalid plate length, needs to be between 2 and 7, your plate length was {LicensePlate.Length} characters long");
            }
        }

        

    }
}