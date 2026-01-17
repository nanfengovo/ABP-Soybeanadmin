// @unocss-include
import { getColorPalette, getRgb } from '@sa/color';
import { DARK_CLASS } from '@/constants/app';
import { localStg } from '@/utils/storage';
import { toggleHtmlClass } from '@/utils/common';
import { $t } from '@/locales';

/**
 * 初始化首屏 Loading
 * - 支持主题色
 * - 支持暗黑模式
 * - SVG 使用 currentColor（可被 CSS 控制）
 */
export function setupLoading() {
  const themeColor = localStg.get('themeColor') || '#646cff';
  const darkMode = localStg.get('darkMode') || false;

  /** 主题色 RGB */
  const { r, g, b } = getRgb(themeColor);

  /** 颜色调色板（给 SVG 用） */
  const palette = getColorPalette(themeColor);

  /** CSS 变量 */
  const primaryColor = `--primary-color: ${r} ${g} ${b}`;
  const svgCssVars = Array.from(palette.entries())
    .map(([key, value]) => `--logo-color-${key}: ${value}`)
    .join(';');

  const cssVars = `${primaryColor};${svgCssVars}`;

  /** 暗黑模式 */
  if (darkMode) {
    toggleHtmlClass(DARK_CLASS).add();
  }

  /** loading dots */
  const loadingClasses = [
    'left-0 top-0',
    'left-0 bottom-0 animate-delay-500',
    'right-0 top-0 animate-delay-1000',
    'right-0 bottom-0 animate-delay-1500'
  ];

  const dotsHtml = loadingClasses
    .map(
      cls => `
      <div class="absolute w-16px h-16px rounded-8px bg-primary animate-pulse ${cls}"></div>
    `
    )
    .join('');

  /** 最终 loading HTML */
  const loadingHtml = `
<div id="app-loading" class="fixed inset-0 flex-center flex-col bg-layout" style="${cssVars}">
  <div class="w-128px h-128px text-primary">
    ${getLogoSvg()}
  </div>

  <div class="relative w-56px h-56px my-36px animate-spin">
    ${dotsHtml}
  </div>

  <h2 class="text-28px font-500 text-primary">
    ${$t('system.title')}
  </h2>
</div>
`;

  const app = document.getElementById('app');
  if (app) {
    app.innerHTML = loadingHtml;
  }
}

/**
 * Logo SVG
 * 注意：
 * 1. fill 使用 currentColor
 * 2. 外层 div 控制颜色（text-primary）
 */
function getLogoSvg(): string {
  return `
<svg
  width="100%"
  height="100%"
  viewBox="0 0 1000 1000"
  xmlns="http://www.w3.org/2000/svg"
>
  <g>
    <path
      d="M 200,866 C 100,866 50,779.4 100,692.8 L 200,519.6 C 220,485 240,490 265,499.6 S 360,542.68 360,542.68 C 480.5,601 498,642.5 500,720 C 498,811 462,856 420,866"
      fill="url(#g1)"
    />
    <path
      d="M 420,866 C 455,861 478,846 500,827 C 614,696 615,597 500,517 C 394,444 333,374 380,207.82"
      fill="url(#g2)"
    />
  </g>
  <defs>
    <linearGradient id="g1" x1="0" x2="1">
      <stop offset="0" stop-color="var(--logo-color-700)" />
      <stop offset="1" stop-color="var(--logo-color-500)" />
    </linearGradient>
    <linearGradient id="g2" x1="0" x2="1">
      <stop offset="0" stop-color="var(--logo-color-300)" />
      <stop offset="1" stop-color="var(--logo-color-600)" />
    </linearGradient>
  </defs>
</svg>
`;
}
