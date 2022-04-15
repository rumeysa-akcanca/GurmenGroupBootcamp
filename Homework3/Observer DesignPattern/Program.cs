// See https://aka.ms/new-console-template for more information

using Observer_DesignPattern;

PostManager manager = new();
manager.AddObserver(new AdminObserver());
manager.AddObserver(new EditorObserver());
manager.UpdatePost();