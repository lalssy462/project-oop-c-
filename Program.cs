public class Helloworld
{
    String halo = "halo";

    int angkaSatu;
    int angkaDua;

    public void fungsiDalamKelas()
    {
        String halojuga = "halooo";
        Console.WriteLine(halojuga);
    }

public void operasiTambah(int angkaSatuPar, int angkaDuaPar)
    {
        this.angkaSatu = angkaSatuPar;
        this.angkaDua = angkaDuaPar;

        Console.WriteLine(angkaSatuPar + angkaDuaPar);
    
    }


public void operasiKurang(int angkaSatuPar, int angkaDuaPar)
    {
        this.angkaSatu = angkaSatuPar;
        this.angkaDua = angkaDuaPar;

        Console.WriteLine(angkaSatuPar - angkaDuaPar);
    
    }


public void operasiKali(int angkaSatuPar, int angkaDuaPar)
    {
        this.angkaSatu = angkaSatuPar;
        this.angkaDua = angkaDuaPar;

        Console.WriteLine(angkaSatuPar * angkaDuaPar);
    
    }



public void operasiBagi(int angkaSatuPar, int angkaDuaPar)
    {
        this.angkaSatu = angkaSatuPar;
        this.angkaDua = angkaDuaPar;

        Console.WriteLine(angkaSatuPar / angkaDuaPar);
    
    }



public static void Main()
{
    Console.WriteLine("Merdeka");
    
    //PEMANGGILAN KELAS DALAM INTERNAL
    Helloworld inisiasiHello = new Helloworld();



    Console.WriteLine(inisiasiHello.halo);

    inisiasiHello.fungsiDalamKelas();
    inisiasiHello.operasiTambah(2,1);
    inisiasiHello.operasiKurang(10,4);
    inisiasiHello.operasiKali(5,3);
    inisiasiHello.operasiBagi(8,5);

}
}