using System.IO.MemoryMappedFiles;

namespace GenericClassImplementation
{
    public class ClassHelpes
    {
        public enum TypeEnum
        {
            Type1,
            Type2, 
            Type3,
        }

        private Dictionary<TypeEnum, IEnumerable<ClassBase>> mapper = new Dictionary<TypeEnum, IEnumerable<ClassBase>>();

        public ClassHelpes() {

            InitDict();
        }


        private void InitDict()
        {
            mapper.Add(TypeEnum.Type1, new List<ClassType1>());
            mapper.Add(TypeEnum.Type2 , new List<ClassType2>());
            mapper.Add (TypeEnum.Type3, new List<ClassType3>());
        }

        public void ImportInfo<T>(TypeEnum type, T data) where T : ClassBase , new()
        {
            var listInfo = GetDictValue<T>(type);
            listInfo = listInfo.Append(data);
            Console.WriteLine(data.GetType());
            foreach (var item in listInfo) { 
                item.ToStringMy();
            }
        }

        public IEnumerable<ClassBase> GetDictValue<T>(TypeEnum type) where T : ClassBase, new()
        {
            var info = mapper[type];
            return info;
        }
    }
}
