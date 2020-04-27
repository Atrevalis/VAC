using Math_Module;
namespace LMath
{
    public static class Config
    {
        public static void Ini()
        {
            Math_Field.Up += new Math_Field.Up_delegaete(Up);
        }

        public static Math_Field Up(Math_Field value)
        {
            switch(value.id)
            {
                case 1:
                    {
                        return (Z)(value as N);
                    }
                case 2:
                    {
                        return (Q)(value as Z);
                    }
                case 3:
                    {
                        return null;
                    }
                case 4:
                    {
                        return null;
                    }
                case 5:
                    {
                        return null;
                    }
                case 6:
                    {
                        return value;
                    }
                default:
                    {
                        return null;
                    }
            }
        }
    }
}
