namespace ShaveddaPizzaria.Models
{
	public class DeleteData
	{
        public int DataId { get; set; }
        public Type DataClass { get; set; }

        public DeleteData(int id, Type dataClass)
        {
            DataId = id;
            DataClass = dataClass;
        }
    }
}
