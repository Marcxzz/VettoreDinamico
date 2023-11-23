using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfacciaElenco
{
    /// <summary>
    /// interfaccia che predispone alla realizzazione della classe Vector che conterrà un vettore dinamico di stringhe
    /// il vettore dinamico viene creato con un solo item (lenght =1 Count=0)
    /// quando si cerca di inserire un nuovo item il numero di elementi inseribili nell'elenco raddoppia (lenght=2)
    /// Ogni volta che si cerca di inserire un nuovo item ma l'elenco è pieno il numero degli elemnti a disposizione continua
    /// a raddoppiare: 1,2,4,8 ....
    /// </summary>
    public interface IElenco
    {
        /// <summary>
        /// Restituisce il numero degli elementi effettivamente inseriti.
        /// </summary>
        int Count { get; }
        /// <summary>
        /// Restituisce di quanti elementi è composto il mio elenco (sia già caricati che vuoti)
        /// </summary>
        int Length { get; }
        /// <summary>
        /// Aggiunge un item dopo l'ultimo inserito.
        /// Se l'elenco è pieno raddoppia le sue dimensioni.
        /// </summary>
        /// <param name="item">stringa da inserire</param>
        void Add(string item);
        /// <summary>
        /// Rimuove l'elemento nella posizione indicata e ricompatta l'elenco.
        /// Se il numero di spazi disponibili supera la metà l'elenco viene dimezzato.
        /// </summary>
        /// <param name="index">posizione</param>
        void RemoveAt(Int32 index);
        /// <summary>
        /// Rimuove tutti gli elementi che corrispondono al parametro item e ricompatta l'elenco.
        /// Se il numero di spazi disponibili supera la metà l'elenco viene dimezzato.
        /// </summary>
        /// <param name="item">stringa da cercare e rimuovere</param>
        void Remove(string item);
        /// <summary>
        /// Restituisce (ma non rimuove) il contenuto dell'elenco nella posizione index.
        /// </summary>
        /// <param name="index"></param>
        string GetItemAt(Int32 index);
    }
}