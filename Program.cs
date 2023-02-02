using Terminal.Gui;
using TEXT_EDITOR;

Application.Init();

try
{
    Application.Run(new MyView());
}
finally
{
    Application.Shutdown();
}