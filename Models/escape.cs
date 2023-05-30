static class escape{
    static string[] incognitaSalas = new string[4];
    static int estadoJuego = 1;
    private static void inicializarJuego(){
        incognitaSalas[0] = "Queso";
        incognitaSalas[1] = "042";
        incognitaSalas[2] = "mama";
        incognitaSalas[3] = "jana";
    }
    public static int estado(){
        return estadoJuego;
    }
    public static bool resolverSala(int sala, string incognita){
        if(sala != estado()){
            return false;
        }
        else{
            if(incognitaSalas[0] == null){
                inicializarJuego();
            }
            if(incognita == incognitaSalas[sala-1]){
                estadoJuego++;
                return false;
            }
        }
        return true;
    }
}