namespace csharp_banca_oop
{
    internal class Prestito
    {
        Cliente intestatario;

        int Amount { get; set; }
        int Rate { get; set; }
        DateTime startDate { get; set; }
        DateTime finishDate { get; set; }
    }
}