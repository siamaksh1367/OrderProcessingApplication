namespace OrderProcessor
{
    public interface IPacking 
    {
        void GenerateSlips();

        void DuplicateSlips();

        void AddFirstAid();
    }
}
