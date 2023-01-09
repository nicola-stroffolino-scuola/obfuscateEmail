# obfuscateEmail
Nasconde parte di un indirizzo mail con asterischi. Il numero e la posizione degli asterischi è parametrizzata in funzione della lunghezza delle varie parti che compongono l'indirizzo mail.  
In particolare:
+ Se la parte che precede la @ è lunga fino a 4 caratteri, dovrà essere visualizzata solo la prima lettera (es: info -> i***)
+ Se la parte che precede la @ è più lunga di 4 caratteri, dovrà essere visualizzata la prima e l'ultima lettera (es: marcello -> m******o)
+ Il dominio di secondo livello (o combinazione di più livelli di dominio) viene sempre visualizzato con le prima e ultima lettera.
+ Nel nome di dominio e nell'indirizzo mail eventuali punti vengono comunque sostituiti da asterischi
+ Il TLD viene sempre riportato per intero (es: net -> net)

Per potere essere offuscato l'indirizzo mail dovrà essere formalmente valido. 
Tale controllo viene effettuato:
+ controllando la presenza di un solo carattere @ 
+ controllando la presenza di almeno un . dopo la @

L'esercizio prevede la scrittura del metodo ObfuscateEmail che verrà utilizzato successivamente all'interno di una classe StringServices dedicata al processamento di stringhe.