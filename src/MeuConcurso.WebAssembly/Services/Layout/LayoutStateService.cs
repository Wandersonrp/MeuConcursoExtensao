using MeuConcurso.WebAssembly.Enums;

namespace MeuConcurso.WebAssembly.Services.Layout;
public class LayoutStateService
{
    public event Action? LayoutChanged;

    public string PageName { get; set; } = string.Empty;
    public LayoutType LayoutType { get; set; } = LayoutType.DefaultWithGoBack;

    public void Setup(LayoutType layoutType, string pageName)
    {
        LayoutType = layoutType;
        PageName = pageName;

        LayoutChanged?.Invoke();
    }
}
