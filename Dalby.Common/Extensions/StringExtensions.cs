namespace Dalby.Common.Extensions
{
    public static class StringExtensions
    {
        public static void WriteTo(this string self, string filePath)
        {
            using Stream stream = File.Open(filePath, FileMode.Create, FileAccess.Write);
            self.WriteTo(stream);
        }
        public static void WriteTo(this string self, Stream stream)
        {
            using StreamWriter writer = new(stream);
            writer.Write(self);
        }
    }
}
