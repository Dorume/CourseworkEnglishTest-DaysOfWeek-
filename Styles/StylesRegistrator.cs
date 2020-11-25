using Lets__study_.Styles.RichTB;
using Microsoft.Extensions.DependencyInjection;

namespace Lets__study_.Styles
{
    static class StylesRegistrator
    {
        public static IServiceCollection AddStyles(this IServiceCollection services) => services
            .AddSingleton<IRichTextBoxStyle, RichTBEnglishStyle>()
            ;
    }
}
