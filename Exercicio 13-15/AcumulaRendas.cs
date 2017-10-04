public class AcumulaRendas{
    
    public double Total { get; set; }

    public AcumulaRendas(){
        this.Total = 0;

    }
    
    public void acumula(IRendimento t) {
        this.Total += t.acumulaRendas();
    }
}