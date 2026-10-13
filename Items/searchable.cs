using System.Net.ServerSentEvents;

public interface Searchable
{
    //public interface Searchable
    //Ne rien mettre dedans, mettre son contenu dans les classes des objets fouillable ex: room

    public Item search();
}