namespace LMath
{
    public static class Config
    {
        public static void Ini()
        {
            Math_Field.Up += new Math_Field.Up_delegaete(Up);
            N.Antiderivative_event += new N.Antiderivative_delegate(Z.Antiderivative_event_do);
            Z.Antiderivative_event += new Z.Antiderivative_delegate(Q.Antiderivative_event_do);
            Q.Antiderivative_event += new Q.Antiderivative_delegate(C.Antiderivative_event_do);
            C.Antiderivative_event += new C.Antiderivative_delegate(P.Antiderivative_event_do);
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
