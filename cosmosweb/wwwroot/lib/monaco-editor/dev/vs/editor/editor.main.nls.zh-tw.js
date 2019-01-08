/*!-----------------------------------------------------------
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Version: 0.5.2(d49899a916fd99840f6f9178f2dd06e0e7013646)
 * Released under the MIT license
 * https://github.com/Microsoft/vscode/blob/master/LICENSE.txt
 *-----------------------------------------------------------*/

define("vs/editor/editor.main.nls.zh-tw", {
	"vs/base/browser/ui/actionbar/actionbar": [
		"{0} ({1})",
	],
	"vs/base/browser/ui/aria/aria": [
		"{0} (再次出現)",
	],
	"vs/base/browser/ui/findinput/findInput": [
		"使用規則運算式",
		"全字拼寫須相符",
		"大小寫須相符",
		"輸入",
	],
	"vs/base/browser/ui/inputbox/inputBox": [
		"錯誤: {0}",
		"警告: {0}",
		"資訊: {0}",
	],
	"vs/base/common/errors": [
		"{0}。錯誤碼: {1}",
		"權限被拒絕 (HTTP {0})",
		"權限被拒絕",
		"{0} (HTTP {1}: {2})",
		"{0} (HTTP {1})",
		"未知的連接錯誤 ({0})",
		"發生未知的連接錯誤。可能是您已經沒有連線到網際網路，或是您連接的伺服器已離線。",
		"{0}: {1}",
		"發生未知的錯誤。如需詳細資訊，請參閱記錄檔。",
		"發生系統錯誤 ({0})",
		"發生未知的錯誤。如需詳細資訊，請參閱記錄檔。",
		"{0} (總計 {1} 個錯誤)",
		"發生未知的錯誤。如需詳細資訊，請參閱記錄檔。",
		"未實作",
		"不合法的狀態: {0}",
		"不合法的引數",
		"不合法的狀態: {0}",
		"不合法的狀態",
		"無法載入需要的檔案。可能是您已經沒有連線到網際網路，或是您連接的伺服器已離線。請重新整理瀏覽器，再試一次。",
		"無法載入必要的檔案。請重新啟動該應用程式，然後再試一次。詳細資料: {0}",
	],
	"vs/base/common/json": [
		"符號無效",
		"數字格式無效",
		"Property name expected",
		"Value expected",
		"Colon expected",
		"Comma expected",
		"Closing brace expected",
		"Closing bracket expected",
		"必須為檔案結尾",
	],
	"vs/base/common/keyCodes": [
		"Windows",
		"Control",
		"Shift",
		"Alt",
		"Command",
		"Windows",
		"Ctrl",
		"Shift",
		"Alt",
		"Command",
		"Windows",
	],
	"vs/base/common/severity": [
		"錯誤",
		"警告",
		"資訊",
	],
	"vs/base/parts/quickopen/browser/quickOpenModel": [
		"{0}，選擇器",
		"選擇器",
	],
	"vs/base/parts/quickopen/browser/quickOpenWidget": [
		"快速選擇器。輸入以縮小結果範圍。",
		"快速選擇器",
	],
	"vs/base/parts/tree/browser/treeDefaults": [
		"Collapse",
	],
	"vs/editor/browser/standalone/standaloneSchemas": [
		"JSON schema for ASP.NET project.json files",
		"Compilation options that are passed through to Roslyn",
		"The version of the dependency.",
		"The type of the dependency. \'build\' dependencies only exist at build time",
		"The dependencies of the application. Each entry specifes the name and the version of a Nuget package.",
		"A command line script or scripts.\r\rAvailable variables:\r%project:Directory% - The project directory\r%project:Name% - The project name\r%project:Version% - The project version",
		"The author of the application",
		"List of files to exclude from publish output (kpm bundle).",
		"Glob pattern to specify all the code files that needs to be compiled. (data type: string or array with glob pattern(s)). Example: [ \'Folder1\\*.cs\', \'Folder2\\*.cs\' ]",
		"Commands that are available for this application",
		"Configurations are named groups of compilation settings. There are 2 defaults built into the runtime namely \'Debug\' and \'Release\'.",
		"The description of the application",
		"Glob pattern to indicate all the code files to be excluded from compilation. (data type: string or array with glob pattern(s)).",
		"Target frameworks that will be built, and dependencies that are specific to the configuration.",
		"Glob pattern to indicate all the code files to be preprocessed. (data type: string with glob pattern).",
		"Glob pattern to indicate all the files that need to be compiled as resources.",
		"Scripts to execute during the various stages.",
		"Glob pattern to specify the code files to share with dependent projects. Example: [ \'Folder1\\*.cs\', \'Folder2\\*.cs\' ]",
		"The version of the application. Example: 1.2.0.0",
		"Specifying the webroot property in the project.json file specifies the web server root (aka public folder). In visual studio, this folder will be used to root IIS. Static files should be put in here.",
		"JSON schema for Bower configuration files",
		"Any property starting with _ is valid.",
		"The name of your package.",
		"Help users identify and search for your package with a brief description.",
		"A semantic version number.",
		"The primary acting files necessary to use your package.",
		"SPDX license identifier or path/url to a license.",
		"A list of files for Bower to ignore when installing your package.",
		"Used for search by keyword. Helps make your package easier to discover without people needing to know its name.",
		"A list of people that authored the contents of the package.",
		"URL to learn more about the package. Falls back to GitHub project if not specified and it\'s a GitHub endpoint.",
		"The repository in which the source code can be found.",
		"Dependencies are specified with a simple hash of package name to a semver compatible identifier or URL.",
		"Dependencies that are only needed for development of the package, e.g., test framework or building documentation.",
		"Dependency versions to automatically resolve with if conflicts occur between packages.",
		"If you set it to  true  it will refuse to publish it. This is a way to prevent accidental publication of private repositories.",
		"Used by grunt-bower-task to specify custom install locations.",
		"The types of modules this package exposes",
		"NPM configuration for this package.",
		"A person who has been involved in creating or maintaining this package",
		"Dependencies are specified with a simple hash of package name to version range. The version range is a string which has one or more space-separated descriptors. Dependencies can also be identified with a tarball or git URL.",
		"Any property starting with _ is valid.",
		"The name of the package.",
		"Version must be parseable by node-semver, which is bundled with npm as a dependency.",
		"This helps people discover your package, as it\'s listed in \'npm search\'.",
		"The relative path to the icon of the package.",
		"This helps people discover your package as it\'s listed in \'npm search\'.",
		"The url to the project homepage.",
		"The url to your project\'s issue tracker and / or the email address to which issues should be reported. These are helpful for people who encounter issues with your package.",
		"The url to your project\'s issue tracker.",
		"The email address to which issues should be reported.",
		"You should specify a license for your package so that people know how they are permitted to use it, and any restrictions you\'re placing on it.",
		"You should specify a license for your package so that people know how they are permitted to use it, and any restrictions you\'re placing on it.",
		"A list of people who contributed to this package.",
		"A list of people who maintains this package.",
		"The \'files\' field is an array of files to include in your project. If you name a folder in the array, then it will also include the files inside that folder.",
		"The main field is a module ID that is the primary entry point to your program.",
		"Specify either a single file or an array of filenames to put in place for the man program to find.",
		"If you specify a \'bin\' directory, then all the files in that folder will be used as the \'bin\' hash.",
		"Put markdown files in here. Eventually, these will be displayed nicely, maybe, someday.",
		"Put example scripts in here. Someday, it might be exposed in some clever way.",
		"Tell people where the bulk of your library is. Nothing special is done with the lib folder in any way, but it\'s useful meta info.",
		"A folder that is full of man pages. Sugar to generate a \'man\' array by walking the folder.",
		"Specify the place where your code lives. This is helpful for people who want to contribute.",
		"The \'scripts\' member is an object hash of script commands that are run at various times in the lifecycle of your package. The key is the lifecycle event, and the value is the command to run at that point.",
		"A \'config\' hash can be used to set configuration parameters used in package scripts that persist across upgrades.",
		"Array of package names that will be bundled when publishing the package.",
		"Array of package names that will be bundled when publishing the package.",
		"If your package is primarily a command-line application that should be installed globally, then set this value to true to provide a warning if it is installed locally.",
		"If set to true, then npm will refuse to publish it.",
		"JSON schema for the ASP.NET global configuration files",
		"A list of project folders relative to this file.",
		"A list of source folders relative to this file.",
		"The runtime to use.",
		"The runtime version to use.",
		"The runtime to use, e.g. coreclr",
		"The runtime architecture to use, e.g. x64.",
		"JSON schema for the TypeScript compiler\'s configuration file",
		"Instructs the TypeScript compiler how to compile .ts files",
		"The character set of the input files",
		"Generates corresponding d.ts files.",
		"Show diagnostic information.",
		"Emit a UTF-8 Byte Order Mark (BOM) in the beginning of output files.",
		"Emit a single file with source maps instead of having a separate file.",
		"Emit the source alongside the sourcemaps within a single file; requires --inlineSourceMap to be set.",
		"Print names of files part of the compilation.",
		"The locale to use to show error messages, e.g. en-us.",
		"Specifies the location where debugger should locate map files instead of generated locations",
		"Specify module code generation: \'CommonJS\', \'Amd\', \'System\', or \'UMD\'.",
		"Specifies the end of line sequence to be used when emitting files: \'CRLF\' (dos) or \'LF\' (unix).)",
		"Do not emit output.",
		"Do not emit outputs if any type checking errors were reported.",
		"Do not generate custom helper functions like __extends in compiled output.",
		"Warn on expressions and declarations with an implied \'any\' type.",
		"Do not include the default library file (lib.d.ts).",
		"Do not add triple-slash references or module import targets to the list of compiled files.",
		"Concatenate and emit output to single file.",
		"Redirect output structure to the directory.",
		"Do not erase const enum declarations in generated code.",
		"Do not emit comments to output.",
		"Specifies the root directory of input files. Use to control the output directory structure with --outDir.",
		"Generates corresponding \'.map\' file.",
		"Specifies the location where debugger should locate TypeScript files instead of source locations.",
		"Suppress noImplicitAny errors for indexing objects lacking index signatures.",
		"Specify ECMAScript target version:  \'ES3\' (default), \'ES5\', or \'ES6\' (experimental).",
		"Watch input files.",
		"Enable the JSX option (requires TypeScript 1.6):  \'preserve\', \'react\'.",
		"Emits meta data.for ES7 decorators.",
		"Supports transpiling single TS files into JS files.",
		"Enables experimental support for ES7 decorators.",
		"Enables experimental support for async functions (requires TypeScript 1.6).",
		"If no \'files\' property is present in a tsconfig.json, the compiler defaults to including all files the containing directory and subdirectories. When a \'files\' property is specified, only those files are included.",
		"JSON schema for the JavaScript configuration file",
		"Instructs the JavaScript language service how to validate .js files",
		"The character set of the input files",
		"Show diagnostic information.",
		"The locale to use to show error messages, e.g. en-us.",
		"Specifies the location where debugger should locate map files instead of generated locations",
		"Module code generation to resolve against: \'commonjs\', \'amd\', \'system\', or \'umd\'.",
		"Do not include the default library file (lib.d.ts).",
		"Specify ECMAScript target version:  \'ES3\' (default), \'ES5\', or \'ES6\' (experimental).",
		"Enables experimental support for ES7 decorators.",
		"If no \'files\' property is present in a jsconfig.json, the language service defaults to including all files the containing directory and subdirectories. When a \'files\' property is specified, only those files are included.",
		"List files and folders that should not be included. This property is not honored when the \'files\' property is present.",
	],
	"vs/editor/common/config/commonEditorConfig": [
		"編輯器組態",
		"控制字型家族。",
		"控制字型大小。",
		"控制行高。",
		"控制是否顯示行號",
		"控制是否顯示字符邊界",
		"要在其中顯示垂直尺規的資料行",
		"執行文字相關導覽或作業時將作為文字分隔符號的字元",
		"與 Tab 相等的空格數量。",
		"必須是 \'number\'。請注意，值 \"auto\" 已由 `editor.detectIndentation` 設定取代。",
		"按 Tab 時插入空格。",
		"必須是 \'boolean\'。請注意，值 \"auto\" 已由 `editor.detect Indentation` 設定取代。",
		"開啟檔案時，會依據檔案內容來偵測 `editor.tabSize` 及 `editor.insertSpaces`。",
		"控制選取範圍是否有圓角",
		"控制編輯器是否會捲動到最後一行之後",
		"控制編輯器換行到下一行的字元數。若將此項目設為 0，將會開啟檢視區寬度換行 (自動換行)。若將此項目設為 -1，將會強制編輯器永不換行。",
		"控制換行的縮排。可以是 [無]、[相同] 或 [縮排]。",
		"滑鼠滾輪捲動事件的 \'deltaX\' 與 \'deltaY\' 所使用的乘數",
		"控制輸入時是否應顯示快速建議",
		"控制延遲顯示快速建議的毫秒數",
		"Enables parameter hints",
		"控制編輯器是否應在左括號後自動插入右括號",
		"控制編輯器是否應在輸入一行後自動格式化",
		"控制輸入觸發字元時，是否應自動顯示建議",
		"控制除了 \'Tab\' 外，是否也藉由按下 \'Enter\' 接受建議。如此可避免混淆要插入新行或接受建議。",
		"控制編輯器是否應反白顯示與選取範圍相似的符合項",
		"控制可在概觀尺規中相同位置顯示的裝飾項目數",
		"控制游標閃爍動畫，接受的值為 \'blink\'、\'visible\' 和 \'hidden\'",
		"控制游標樣式，接受的值為 \'block\' 和 \'line\'",
		"啟用連字字型",
		"控制游標是否應隱藏在概觀尺規中。",
		"控制編輯器是否應顯示空白字元",
		"控制編輯器是否會顯示支援編輯器的模式之參考資訊",
		"控制編輯器是否已啟用程式碼摺疊功能",
		"插入和刪除接在定位停駐點後的空白字元",
		"移除尾端自動插入的空白字元",
		"Keep peek editors open even when double clicking their content or when hitting Escape.",
		"控制 Diff 編輯器要並排或內嵌顯示差異",
		"控制 Diff 編輯器是否將開頭或尾端空白字元的變更顯示為差異",
		"控制是否應支援 Linux 主要剪貼簿。",
	],
	"vs/editor/common/config/defaultConfig": [
		"編輯器內容",
	],
	"vs/editor/common/controller/cursor": [
		"執行命令時發生未預期的例外狀況。",
	],
	"vs/editor/common/model/textModelWithTokens": [
		"將輸入語彙基元化時，模式失敗。",
	],
	"vs/editor/common/modes/modesRegistry": [
		"純文字",
	],
	"vs/editor/common/modes/supports/suggestSupport": [
		"啟用字組式建議。",
	],
	"vs/editor/common/services/bulkEdit": [
		"這些檔案已同時變更: {0}",
	],
	"vs/editor/common/services/modeServiceImpl": [
		"提供語言宣告。",
		"語言的識別碼。",
		"語言的別名名稱。",
		"與語言相關聯的副檔名。",
		"與語言相關聯的檔案名稱。",
		"與語言相關聯的檔案名稱 Glob 模式。",
		"與語言相關聯的 MIME 類型。",
		"規則運算式，符合語言檔案的第一行。",
		"檔案的相對路徑，其中該檔案包含語言組態選項。",
		"`contributes.{0}` 值為空值",
		"屬性 \'{0}\' 為強制項目且必須屬於 `string` 類型",
		"屬性 \'{0}\' 可以省略且必須屬於 `string[]` 類型",
		"屬性 \'{0}\' 可以省略且必須屬於 `string[]` 類型",
		"屬性 \'{0}\' 可以省略且必須屬於 `string` 類型",
		"屬性 \'{0}\' 可以省略且必須屬於 `string` 類型",
		"屬性 \'{0}\' 可以省略且必須屬於 `string[]` 類型",
		"屬性 \'{0}\' 可以省略且必須屬於 `string[]` 類型",
		"`contributes.{0}` 無效。必須是陣列。",
	],
	"vs/editor/common/services/modelServiceImpl": [
		"請更新您的設定: `editor.detect Indentation` 會取代 `editor.tabSize`: \"auto\" 或  `editor.insertSpaces`: \"auto\"",
	],
	"vs/editor/contrib/accessibility/browser/accessibility": [
		"顯示協助工具說明",
		"感謝您試用 VSCode 的實驗協助工具選項。",
		"狀態:",
		"在此編輯器中按 Tab 鍵會將焦點移至下一個可設定焦點的元素。按 {0} 可切換此行為。",
		"在此編輯器中按 Tab 鍵會將焦點移至下一個可設定焦點的元素。目前無法透過按鍵繫結關係觸發命令 {0}。",
		"在此編輯器中按 Tab 鍵會插入定位字元。按 {0} 可切換此行為。",
		"在此編輯器中按 Tab 鍵會將焦點移至下一個可設定焦點的元素。目前無法透過按鍵繫結關係觸發命令 {0}。",
		"您可以按 Esc 鍵來解除此工具提示並返回編輯器。",
	],
	"vs/editor/contrib/carretOperations/common/carretOperations": [
		"Move Carret Left",
		"Move Carret Right",
	],
	"vs/editor/contrib/clipboard/browser/clipboard": [
		"剪下",
		"複製",
		"貼上",
	],
	"vs/editor/contrib/comment/common/comment": [
		"切換行註解",
		"加入行註解",
		"移除行註解",
		"切換區塊註解",
	],
	"vs/editor/contrib/contextmenu/browser/contextmenu": [
		"顯示編輯器內容功能表",
	],
	"vs/editor/contrib/defineKeybinding/browser/defineKeybinding": [
		"定義按鍵繫結關係",
		"按下所需的按鍵組合，再按 ENTER 鍵",
		"定義按鍵繫結關係",
		"針對您目前的鍵盤配置，請按 ",
		"您無法在目前的鍵盤配置下產生此按鍵組合。",
	],
	"vs/editor/contrib/find/browser/findWidget": [
		"尋找",
		"尋找",
		"上一個符合項",
		"下一個相符項",
		"在選取範圍中尋找",
		"關閉",
		"取代",
		"取代",
		"取代",
		"全部取代",
		"切換取代模式",
		"只會將前 999 筆結果醒目提示，但所有尋找作業會在完整文字上執行。",
		"{0} / {1}",
		"沒有結果",
	],
	"vs/editor/contrib/find/common/findController": [
		"選取所有找到的相符項出現處",
		"變更所有發生次數",
		"尋找",
		"尋找下一個",
		"尋找上一個",
		"尋找下一個選取項目",
		"尋找上一個選取項目",
		"取代",
		"將最後一個選擇項目移至下一個找到的相符項",
		"將選取項目加入下一個找到的相符項",
	],
	"vs/editor/contrib/folding/browser/folding": [
		"展開",
		"Unfold Recursively",
		"摺疊",
		"Fold Recursively",
		"全部摺疊",
		"全部展開",
		"摺疊層級 1",
		"摺疊層級 2",
		"摺疊層級 3",
		"摺疊層級 4",
		"摺疊層級 5",
	],
	"vs/editor/contrib/format/common/formatActions": [
		"格式化程式碼",
	],
	"vs/editor/contrib/goToDeclaration/browser/goToDeclaration": [
		" - {0} 個定義",
		"按一下以顯示找到的 {0} 個定義。",
		"預覽定義",
		"移至定義",
		"在一側開啟定義",
	],
	"vs/editor/contrib/gotoError/browser/gotoError": [
		"建議的修正程式: ",
		"建議的修正程式: ",
		"({0}/{1}) [{2}]",
		"({0}/{1})",
		"移至下一個錯誤或警告",
		"移至上一個錯誤或警告",
	],
	"vs/editor/contrib/hover/browser/hover": [
		"動態顯示",
	],
	"vs/editor/contrib/hover/browser/modesContentHover": [
		"正在載入...",
	],
	"vs/editor/contrib/inPlaceReplace/common/inPlaceReplace": [
		"以上一個值取代",
		"以下一個值取代",
	],
	"vs/editor/contrib/indentation/common/indentation": [
		"已設定的定位點大小",
		"選取目前檔案的定位點大小",
		"將縮排轉換成空格",
		"將縮排轉換成定位點",
		"使用空格鍵進行縮排",
		"使用 Tab 進行縮排",
		"偵測內容中的縮排",
		"切換轉譯空白字元",
	],
	"vs/editor/contrib/linesOperations/common/linesOperations": [
		"刪除行",
		"遞增排序行",
		"遞減排序行",
		"修剪尾端空白",
		"下移一行",
		"上移一行",
		"將行向下複製",
		"將行向上複製",
		"縮排行",
		"凸排行",
		"在上方插入行",
		"在下方插入行",
	],
	"vs/editor/contrib/links/browser/links": [
		"按住 Cmd 並按一下按鍵以追蹤連結",
		"按住 CTRL 並按一下按鍵以追蹤連結",
		"URI 無效: 無法開啟 {0}",
		"開啟連結",
	],
	"vs/editor/contrib/multicursor/common/multicursor": [
		"在上方加入游標",
		"在下方加入游標",
		"從選取的行建立多個游標",
	],
	"vs/editor/contrib/parameterHints/browser/parameterHints": [
		"觸發參數提示",
	],
	"vs/editor/contrib/parameterHints/browser/parameterHintsWidget": [
		"{0}，提示",
	],
	"vs/editor/contrib/quickFix/browser/quickFix": [
		"Quick Fix",
	],
	"vs/editor/contrib/quickFix/browser/quickFixSelectionWidget": [
		"{0}，快速檢修建議",
		"正在載入...",
		"沒有修正建議。",
		"Quick Fix",
		"{0}，接受",
	],
	"vs/editor/contrib/quickOpen/browser/gotoLine": [
		"移至行 {0} 和資料行 {1}",
		"移至第 {0} 行",
		"輸入介於 1 到 {0} 之間要瀏覽至的行號",
		"輸入介於 1 和 {0} 之間要瀏覽至的資料行",
		"Go to line {0}",
		"移至行...",
		"輸入行號，後接選擇性的冒號和資料行數字，以瀏覽至",
	],
	"vs/editor/contrib/quickOpen/browser/gotoLine.contribution": [
		"移至行...",
	],
	"vs/editor/contrib/quickOpen/browser/quickCommand": [
		"{0}, commands",
		"命令選擇區",
		"輸入您想要執行的動作名稱",
	],
	"vs/editor/contrib/quickOpen/browser/quickCommand.contribution": [
		"命令選擇區",
	],
	"vs/editor/contrib/quickOpen/browser/quickOutline": [
		"{0}, symbols",
		"移至符號...",
		"請輸入您想要瀏覽至的識別項名稱",
		"符號 ({0})",
		"模組 ({0})",
		"類別 ({0})",
		"介面 ({0})",
		"方法 ({0})",
		"函式 ({0})",
		"屬性 ({0})",
		"變數 ({0})",
		"變數 ({0})",
		"建構函式 ({0})",
		"呼叫 ({0})",
	],
	"vs/editor/contrib/quickOpen/browser/quickOutline.contribution": [
		"移至符號...",
	],
	"vs/editor/contrib/referenceSearch/browser/referenceSearch": [
		" - {0} 個參考",
		"尋找所有參考",
		"顯示參考",
	],
	"vs/editor/contrib/referenceSearch/browser/referencesController": [
		"正在載入...",
	],
	"vs/editor/contrib/referenceSearch/browser/referencesWidget": [
		"Failed to resolve file.",
		"{0} 個參考",
		"{0} 個參考",
		"no preview available",
		"參考",
		"沒有結果",
		"參考",
	],
	"vs/editor/contrib/rename/browser/rename": [
		"重新命名符號",
	],
	"vs/editor/contrib/rename/browser/renameInputField": [
		"為輸入重新命名。請鍵入新名稱，然後按 Enter 以認可。",
	],
	"vs/editor/contrib/rename/common/rename": [
		"沒有結果。",
	],
	"vs/editor/contrib/smartSelect/common/jumpToBracket": [
		"移至方括弧",
	],
	"vs/editor/contrib/smartSelect/common/smartSelect": [
		"展開選取",
		"縮小選取",
	],
	"vs/editor/contrib/suggest/browser/suggest": [
		"觸發建議",
	],
	"vs/editor/contrib/suggest/browser/suggestWidget": [
		"進一步了解...{0}",
		"{0}，建議，有詳細資料",
		"{0}，建議",
		"返回",
		"正在載入...",
		"無建議。",
		"{0}，接受",
		"{0}，建議，有詳細資料",
		"{0}，建議",
	],
	"vs/editor/contrib/toggleTabFocusMode/common/toggleTabFocusMode": [
		"切換使用 TAB 鍵來設定焦點",
	],
	"vs/editor/contrib/toggleWordWrap/common/toggleWordWrap": [
		"檢視: 切換自動換行",
	],
	"vs/editor/contrib/zoneWidget/browser/peekViewWidget": [
		"關閉",
	],
	"vs/languages/html/common/html.contribution": [
		"HTML 設定",
		"每行的字元數上限 (0 = 停用)。",
		"不應重新格式化的標記清單，須以逗號分隔。\'null\' 的預設值為所有內嵌標記。",
		"縮排 <head> 及 <body> 區段。",
		"是否應保留項目前方現有的分行符號。僅適用於項目前方，而不適用於標記內或文字。",
		"一個區塊要保留的最大分行符號數。使用 \'null\' 表示無限制。",
		"格式化並縮排 {{#foo}} 及 {{/foo}}。",
		"以新行字元結尾。",
		"前方應有額外新行字元的標記清單，須以逗號分隔。\'null\' 的預設值為 \"head, body, /html\"。",
	],
	"vs/languages/json/common/json.contribution": [
		"JSON 組態",
		"將結構描述與目前專案中的 JSON 檔案建立關聯",
		"前往結構描述的 URL，或在目前目錄中前往結構描述的相對路徑",
		"可含有 \'*\' 的檔案模式；在將 JSON 檔案解析為結構描述時可用來比對。",
		"在將 JSON 檔案解析為結構描述時，用來比對的檔案模式陣列。",
		"指定 URL 的結構描述定義。您只需要提供結構描述，以避免存取結構描述 URL。",
	],
	"vs/platform/actions/browser/menuItemActionItem": [
		"{0} ({1})",
	],
	"vs/platform/configuration/common/configurationRegistry": [
		"提供組態設定。",
		"設定的摘要。此標籤將會在設定檔中作為分隔註解使用。",
		"組態屬性的描述。",
		"如果已設定，\'configuration.type\' 必須設定為物件",
		"\'configuration.title\' 必須是字串",
		"\'configuration.properties\' 必須是物件",
	],
	"vs/platform/extensions/common/abstractExtensionService": [
		"擴充功能 `{1}` 無法啟動。原因: 未知的相依性 `{0}`。",
		"擴充功能 `{1}` 無法啟動。原因: 相依性 `{0}` 無法啟動。",
		"擴充功能 `{0}` 無法啟動。原因: 相依性超過 10 個層級 (很可能是相依性迴圈)。",
		"啟動擴充功能 `{0}` 失敗: {1}。",
	],
	"vs/platform/extensions/common/extensionsRegistry": [
		"得到空白擴充功能描述",
		"屬性 \'{0}\' 為強制項目且必須屬於 `string` 類型",
		"屬性 \'{0}\' 為強制項目且必須屬於 `string` 類型",
		"屬性 \'{0}\' 為強制項目且必須屬於 `string` 類型",
		"屬性 \'{0}\' 為強制項目且必須屬於 `object` 類型",
		"屬性 \'{0}\' 為強制項目且必須屬於 `string` 類型",
		"屬性 `{0}` 可以省略或必須屬於 `string[]` 類型",
		"屬性 `{0}` 可以省略或必須屬於 `string[]` 類型",
		"屬性 `{0}` 和 `{1}` 必須同時指定或同時忽略",
		"屬性 `{0}` 可以省略或必須屬於 `string` 類型",
		"`main` ({0}) 必須包含在擴充功能的資料夾 ({1}) 中。這可能會使擴充功能無法移植。",
		"屬性 `{0}` 和 `{1}` 必須同時指定或同時忽略",
		"VS Code 資源庫中使用的擴充功能顯示名稱。",
		"VS Code 資源庫用來將擴充功能歸類的分類。",
		"用於 VS Code Marketplace 的橫幅。",
		"VS Code Marketplace 頁首的橫幅色彩。",
		"橫幅中使用的字型色彩佈景主題。",
		"VS Code 擴充功能的發行者。",
		"VS Code 擴充功能的啟動事件。",
		"其它擴充功能的相依性。擴充功能的識別碼一律為 ${publisher}.${name}。例如: vscode.csharp。",
		"在封裝作為 VS Code 擴充功能發行前所執行的指令碼。",
		"此封裝所代表的所有 VS Code 擴充功能比重。",
	],
	"vs/platform/jsonschemas/common/jsonContributionRegistry": [
		"使用結構描述來描述 JSON 檔案。如需詳細資訊，請參閱 json-schema.org。",
		"結構描述的唯一識別碼。",
		"結構描述，用來驗證此文件",
		"元素的描述性標題",
		"元素的詳細描述。用於暫留功能表和建議。",
		"預設值。供建議使用。",
		"應該會整除目前值的數字 (即沒有餘數)",
		"最大數值，預設為包含。",
		"將最大值屬性設為排除。",
		"最小數值，預設為包含。",
		"將最小值屬性設為排除。",
		"字串的最大長度。",
		"字串的最小長度。",
		"規則運算式，用來比對字串。其未隱含錨定。",
		"用於陣列 (只有在項目設為陣列時)。如果為結構描述，這個結構描述會驗證項目陣列所指定的項目之後的項目。如果為 False，則額外的項目會導致驗證失敗。",
		"用於陣列。可以是用來比對驗證每個元素的結構描述，或是用來依序比對驗證每個項目的結構描述陣列 (第一個結構描述驗證第一個元素，第二個結構描述驗證第二個元素，依此類推)。",
		"可包含在陣列中的最大項目數。包含。",
		"可包含在陣列中的最小項目數。包含。",
		"陣列中的所有項目是否都必須為唯一。預設為 False。",
		"物件可具有的最大屬性數目。包含。",
		"物件可具有的最小屬性數目。包含。",
		"這個字串陣列會列出這個物件所需的所有屬性的名稱。",
		"為結構描述或布林值。若為結構描述，將會用以驗證所有不符合 \'properties\' 或 \'patternProperties\' 的屬性。若為 false，則所有不符合這兩項其中之一的屬性，都會導致此結構描述失敗。",
		"不用於驗證。將您要利用 $ref 內嵌參考的子結構描述置於此",
		"每個屬性的屬性名稱對結構描述對應。",
		"屬性名稱的規則運算式對結構描述的對應，用於比對屬性。",
		"屬性名稱對屬性名稱陣列或結構描述的對應。屬性名稱陣列表示索引鍵中的命名屬性若要有效，陣列中的屬性必須出現在物件中。如果值是結構描述，則只有在索引鍵中的屬性存在物件上時才會將結構描述套用到該物件。",
		"有效常值的集合",
		"可以是其中一個基本結構描述類型 (數字、整數、null、陣列、物件、布林值、字串) 的字串，或是指定這些類型子集的字串陣列。",
		"描述此值預期的格式。",
		"結構描述的陣列，必須全部符合。",
		"結構描述的陣列，其中至少一個必須符合。",
		"結構描述的陣列，其中剛好一個必須符合。",
		"不能相符的結構描述。",
	],
	"vs/platform/keybinding/browser/keybindingServiceImpl": [
		"其他可用命令如下: ",
		"已按下 ({0})。請等待第二個套索鍵...",
		"按鍵組合 ({0}, {1}) 不是命令。",
	],
	"vs/platform/message/common/message": [
		"關閉",
		"取消",
	]
});