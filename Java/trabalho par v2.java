String opcao;
        int classif = 0;
        boolean dados = false;
        
        Scanner leia = new Scanner( System.in );
        
        do{
            System.out.println( "(I)  Inserir Salario");
            System.out.println( "(A)  Aumento de 1.00%");
            System.out.println( "(B)  Aumento de 1.50%");
            System.out.println( "(C)  Aumento de 1.70%");
            System.out.println( "(D)  Aumento de 2.00%");
            System.out.println( "(E) Aumento de 2.25%");
            System.out.println( "(F)  Fim");
            
            opcao = leia.nextLine();
            
            switch( opcao ){
                
                case "a":
                case "A":  
                    do{
                        System.out.print("Insira a classificaÃ§Ã£o: ");
                        classif = leia.nextInt();
                    }while( classif<0 || classif > 20);
                    dados = true;
                    break;
                            
                case "b":
                case "B":            
                    if( dados ){
                        if( classif>=0 && classif<=4)
                            System.out.println("ClassificaÃ§Ã£o correta");
                        else
                            System.out.println("ClassificaÃ§Ã£o incorreta");                           
                    }
                    break;
                    
                case "c":
                case "C":
                    if( dados ){
                        if( classif>=5 && classif<=9)
                            System.out.println("ClassificaÃ§Ã£o correta");
                        else
                            System.out.println("ClassificaÃ§Ã£o incorreta");                           
                    }
                    break;
                    
                case "d":
                case "D":
                    if( dados ){
                        if( classif>=10 && classif<=13)
                            System.out.println("ClassificaÃ§Ã£o correta");
                        else
                            System.out.println("ClassificaÃ§Ã£o incorreta");                           
                    }
                    break;
                    
                case "e":
                case "E":
                    if( dados ){
                        if( classif>=14 && classif<=17)
                            System.out.println("ClassificaÃ§Ã£o correta");
                        else
                            System.out.println("ClassificaÃ§Ã£o incorreta");                           
                    }
                    break;
                    
                case "f":
                case "F":
                    if( dados ){
                        if( classif>=18 && classif<=20)
                            System.out.println("ClassificaÃ§Ã£o correta");
                        else
                            System.out.println("ClassificaÃ§Ã£o incorreta");                           
                    }
                    break;
                    
                 default:
                     System.out.println( "OpÃ§Ã£o invÃ¡lida!"); 
            } 
            
        } while( !opcao.equals("f") && !opcao.equals("F") ); 
    }   
}