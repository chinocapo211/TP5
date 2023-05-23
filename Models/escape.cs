static class escape{
    static string[] incogrnitaSalas;
    static int estadoJuego = 0;
    private static void inicializarJuego(){
        incogrnitaSalas[0] = "quezo";
        incogrnitaSalas[1] = "zapallo";
        incogrnitaSalas[2] = "mama";
        incogrnitaSalas[3] = "jana";
    }
    public static int estado(){
        return estadoJuego;
    }
    public static bool resolverSala(int sala, string incognita){
        if(sala >= estado()){
            return false;
        }
        else{
            if(incogrnitaSalas[0] == ""){
                inicializarJuego();
            }
            if(incognita == incogrnitaSalas[sala]){
                estadoJuego++;
            }
        }
        return true;
    }
}