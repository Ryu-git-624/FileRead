using System;

namespace FileRead
{
    public static class MemberFactory
    {
        internal static IFile Create(string memberKind)
        {
            if (memberKind == "Silver")
            {
                return new Silver();
            }
            
            if (memberKind == "Gold")
            {
                return new Gold();
            }
            
            if (memberKind == "Platinum")
            {
                return new Platinum();
            }

            throw new ArgumentException("memberKindが不正です。");
        }
    }
}
