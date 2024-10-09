using Microsoft.AspNetCore.Components;

namespace BlazorSectionOutletIssueRepro.Components;

public partial class TestComponent
{
    [Parameter]
    public EventCallback OnClick { get; set; }

    protected override void OnInitialized()
    {
        Console.WriteLine("TestComponent:OnInitialized");
        base.OnInitialized();
    }
}