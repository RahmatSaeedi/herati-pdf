<div dir="rtl" align="right">

# دری | Dari

# Stitch PDF - تبدیل‌کننده و ادغام‌کننده PDF

<div align="center">

![Stitch PDF Logo](wwwroot/icon-192.png)

**یک ابزار قدرتمند و محرمانه برای کار با PDF که کاملاً در مرورگر شما اجرا می‌شود**

[![.NET 10](https://img.shields.io/badge/.NET-10-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
[![Blazor WebAssembly](https://img.shields.io/badge/Blazor-WebAssembly-512BD4?logo=blazor)](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
[![PWA](https://img.shields.io/badge/PWA-enabled-5A0FC8?logo=pwa)](https://web.dev/progressive-web-apps/)
[![No Server Required](https://img.shields.io/badge/server-not%20required-success)](https://github.com)

[ویژگی‌ها](#-ویژگیها) • [استفاده](#-استفاده) • [حریم خصوصی](#-حریم-خصوصی-و-امنیت)

</div>

---

## 🎯 مرور کلی

**Stitch PDF** یک ابزار مدرن و پر از امکانات برای کار با PDF است که به عنوان یک برنامه وب پیشرفته (PWA) با استفاده از Blazor WebAssembly ساخته شده است. برخلاف ابزارهای سنتی PDF، Stitch همه چیز را **۱۰۰٪ در سمت کاربر** پردازش می‌کند — فایل‌های شما هرگز از مرورگر خارج نمی‌شوند و حریم خصوصی و امنیت کامل تضمین می‌شود.

چه نیاز به ادغام PDF داشته باشید، چه تبدیل اسناد به PDF، افزودن امضا، استخراج متن با OCR، یا اعمال واترمارک، Stitch همه را بدون نیاز به اتصال اینترنت یا آپلود به سرور انجام می‌دهد.

### چرا Stitch؟

- **🔒 حریم خصوصی اول** - تمام پردازش‌ها در مرورگر شما انجام می‌شود. فایل‌های شما در دستگاه شما می‌مانند.
- **⚡ سرعت بالا** - بدون رفت و برگشت به سرور. فایل‌ها را فوراً پردازش کنید.
- **📴 کار آفلاین** - به عنوان PWA نصب کنید و بدون اتصال اینترنت استفاده کنید.
- **💰 کاملاً رایگان** - بدون اشتراک، بدون آپلود، بدون محدودیت.
- **🌍 دسترسی جهانی** - روی هر دستگاهی با مرورگر مدرن کار می‌کند.
- **🎨 رابط کاربری زیبا** - طراحی مدرن Material با پشتیبانی از حالت تاریک.

---

## ✨ ویژگی‌ها

### 🔧 عملکردهای اصلی

#### عملیات PDF
- **ادغام PDF** - چندین فایل PDF را در یک سند ترکیب کنید
- **تقسیم PDF** - صفحات خاص را استخراج کنید یا به چند فایل تقسیم کنید
- **حذف صفحات** - صفحات ناخواسته را از PDF حذف کنید
- **چرخش صفحات** - صفحات را به صورت جداگانه یا کل سند بچرخانید (۹۰°، ۱۸۰°، ۲۷۰°)
- **ترتیب مجدد صفحات** - با کشیدن و رها کردن ترتیب صفحات را تغییر دهید
- **فشرده‌سازی PDF** - حجم فایل را با تنظیمات کیفیت قابل تنظیم کاهش دهید
- **محافظت با رمز عبور** - PDF را با رمز عبور کاربر و مالک رمزگذاری کنید

#### تبدیل اسناد
فرمت‌های زیر را به PDF تبدیل کنید:
- **اسناد آفیس**: DOCX، XLSX، XLS، ODS
- **تصاویر**: PNG، JPG، JPEG، WebP، GIF، BMP، TIFF، AVIF، HEIC/HEIF
- **گرافیک برداری**: SVG
- **فرمت‌های متنی**: TXT، Markdown، CSV، HTML، XML، JSON
- **آرشیوها**: ZIP (استخراج و پردازش تمام فایل‌های داخل)

### 🚀 ویژگی‌های پیشرفته

#### ✍️ امضای الکترونیکی
- **رسم امضا** - رسم آزاد با ماوس یا لمس
- **تایپ امضا** - چندین سبک و اندازه فونت
- **آپلود امضا** - استفاده از تصاویر امضای موجود
- **کتابخانه امضا** - ذخیره و استفاده مجدد از امضاها (ذخیره محلی)

#### 🔍 OCR (تشخیص نوری کاراکتر)
- **استخراج متن** - استخراج متن از تصاویر و PDF‌های اسکن شده با Tesseract.js
- **بیش از ۱۱۰ زبان** - پشتیبانی از انگلیسی، فارسی، پشتو، عربی، چینی، ژاپنی و بیشتر
- **کپی به کلیپ‌بورد** - کپی آسان متن استخراج شده

#### 🏷️ کدهای QR و بارکد
- **تولید کد QR** - ایجاد کدهای QR از URL، متن یا اطلاعات تماس
- **پشتیبانی بارکد** - تولید CODE128، CODE39، EAN-13، UPC، ITF-14
- **جاگذاری در PDF** - قرار دادن کدها در صفحات خاص با موقعیت سفارشی

#### 🎨 واترمارک و برندینگ
- **واترمارک متنی** - افزودن متن سفارشی با فونت، اندازه و رنگ
- **واترمارک تصویری** - قرار دادن تصاویر یا لوگوها
- **کنترل شفافیت** - تنظیم شفافیت برای برندینگ ظریف

#### 📄 شماره‌گذاری صفحات
- **هدر و فوتر** - افزودن شماره صفحه، هدر و فوتر
- **فرمت‌های سفارشی** - "صفحه X از Y"، "X/Y" و غیره
- **موقعیت‌یابی** - بالا، پایین، چپ، راست یا وسط

#### 📱 اسکن اسناد
- **یکپارچگی با دوربین** - اسکن مستقیم اسناد از دوربین دستگاه
- **اسکن چند صفحه‌ای** - اسکن چندین صفحه به صورت متوالی
- **PDF فوری** - تبدیل فوری اسکن‌ها به PDF

---

## 🔒 حریم خصوصی و امنیت

### داده‌های شما امن است

- **پردازش ۱۰۰٪ سمت کاربر**: تمام عملیات فایل در مرورگر شما با WebAssembly و JavaScript انجام می‌شود
- **بدون آپلود به سرور**: فایل‌های شما هرگز دستگاه شما را ترک نمی‌کنند
- **بدون جمع‌آوری داده**: ما فایل‌های شما را ردیابی، ذخیره یا تجزیه و تحلیل نمی‌کنیم
- **بدون نیاز به حساب کاربری**: بدون ثبت‌نام، بدون اطلاعات شخصی
- **متن‌باز**: شفافیت کامل - خودتان کد را بررسی کنید

---

## 📦 استفاده

### گزینه ۱: استفاده آنلاین (توصیه شده)

به سادگی از [لینک برنامه](https://rahmatsaeedi.github.io/herati-stitch-pdf/) بازدید کنید و بلافاصله شروع به استفاده کنید. نیازی به نصب نیست!

### گزینه ۲: نصب به عنوان PWA

۱. از برنامه وب در مرورگر خود بازدید کنید
۲. روی دکمه **نصب** در نوار آدرس کلیک کنید
۳. برنامه روی دستگاه شما نصب می‌شود و به صورت آفلاین در دسترس خواهد بود

---

## 🌟 حمایت از این پروژه

اگر این پروژه را مفید می‌دانید، لطفاً در نظر بگیرید:
- ⭐ ستاره دادن به مخزن
- 🐛 گزارش باگ‌ها و مشکلات
- 💡 پیشنهاد ویژگی‌های جدید
- 🔀 مشارکت در بهبود کد
- 📢 به اشتراک گذاری با دیگران

---

<div align="center">

**ساخته شده با ❤️ با استفاده از Blazor WebAssembly**

</div>

</div>

---

<div dir="rtl" align="right">

# پښتو | Pashto

# Stitch PDF - د PDF بدلونکی او یوځای کونکی

<div align="center">

![Stitch PDF Logo](wwwroot/icon-192.png)

**یو پیاوړی او خصوصي وسیله د PDF سره د کار لپاره چې په بشپړ ډول ستاسو په براوزر کې کار کوي**

[![.NET 10](https://img.shields.io/badge/.NET-10-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
[![Blazor WebAssembly](https://img.shields.io/badge/Blazor-WebAssembly-512BD4?logo=blazor)](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
[![PWA](https://img.shields.io/badge/PWA-enabled-5A0FC8?logo=pwa)](https://web.dev/progressive-web-apps/)
[![No Server Required](https://img.shields.io/badge/server-not%20required-success)](https://github.com)

[ځانګړتیاوې](#-ځانګړتیاوې) • [کارول](#-کارول) • [محرمیت](#-محرمیت-او-امنیت)

</div>

---

## 🎯 عمومي کتنه

**Stitch PDF** د PDF سره د کار لپاره یوه عصري او ډکه وسیله ده چې د پرمختللي ویب اپلیکیشن (PWA) په توګه د Blazor WebAssembly په کارولو سره جوړه شوې. د دودیزو PDF وسیلو برعکس، Stitch هرڅه **۱۰۰٪ د کارونکي په اړخ** پروسس کوي — ستاسو فایلونه هیڅکله له براوزر څخه نه وځي، او بشپړ محرمیت او امنیت تضمین کیږي.

که تاسو د PDF یوځای کولو ته اړتیا لرئ، که سندونه PDF ته بدلول، لاسلیک اضافه کول، د OCR سره متن استخراج کول، یا واټرمارک پلي کول، Stitch دا ټول کار پرته له انټرنیټ اتصال یا سرور ته اپلوډ کولو سره ترسره کوي.

### ولې Stitch؟

- **🔒 محرمیت لومړی** - ټول پروسس ستاسو په براوزر کې ترسره کیږي. ستاسو فایلونه ستاسو په وسیله کې پاتې کیږي.
- **⚡ ډیر چټک** - پرته له سرور ته تګ راتګ. فایلونه سمدستي پروسس کړئ.
- **📴 آفلاین کار کول** - د PWA په توګه نصب کړئ او پرته له انټرنیټ اتصال وکاروئ.
- **💰 په بشپړ ډول وړیا** - پرته له ګډون، پرته له اپلوډ، پرته له محدودیت.
- **🌍 نړیوال لاسرسی** - په هره وسیله کې چې عصري براوزر ولري کار کوي.
- **🎨 ښکلی انٹرفیس** - عصري Material ډیزاین د تیاره حالت ملاتړ سره.

---

## ✨ ځانګړتیاوې

### 🔧 اصلي فعالیتونه

#### د PDF عملیات
- **د PDF یوځای کول** - ډیری PDF فایلونه په یوه سند کې یوځای کړئ
- **د PDF ویشل** - ځانګړي مخونه استخراج کړئ یا په ډیرو فایلونو ووېشئ
- **د مخونو حذف کول** - ناغوښتل مخونه له PDF څخه لرې کړئ
- **د مخونو ګرځول** - مخونه په انفرادي ډول یا ټول سند وګرځوئ (۹۰°، ۱۸۰°، ۲۷۰°)
- **د مخونو بیا ترتیب** - د کښلو او پریښودلو سره د مخونو ترتیب بدل کړئ
- **د PDF فشرده کول** - د فایل اندازه د تنظیم وړ کیفیت ترتیباتو سره کم کړئ
- **د پټنوم ساتنه** - PDF د کارونکي او مالک پټنوم سره کوډ کړئ

#### د سندونو بدلون
لاندې فارمیټونه PDF ته بدل کړئ:
- **د دفتر سندونه**: DOCX، XLSX، XLS، ODS
- **انځورونه**: PNG، JPG، JPEG، WebP، GIF، BMP، TIFF، AVIF، HEIC/HEIF
- **ویکتور ګرافیک**: SVG
- **متني فارمیټونه**: TXT، Markdown، CSV، HTML، XML، JSON
- **آرشیفونه**: ZIP (د دننه ټول فایلونه استخراج او پروسس کوي)

### 🚀 پرمختللي ځانګړتیاوې

#### ✍️ بریښنایی لاسلیک
- **د لاسلیک رسم** - د ماوس یا لمس سره آزاد رسم
- **د لاسلیک ټایپ** - څو فونټ سټایلونه او اندازې
- **د لاسلیک اپلوډ** - د موجوده لاسلیک انځورونو کارول
- **د لاسلیک کتابتون** - لاسلیکونه خوندي کړئ او بیا وکاروئ (محلي ذخیره)

#### 🔍 OCR (د توري پیژندنه)
- **د متن استخراج** - له انځورونو او سکین شویو PDFونو څخه متن استخراج کړئ
- **له ۱۱۰ څخه ډیرې ژبې** - د انګلیسي، فارسي، پښتو، عربي، چینایي، جاپاني او نورو ملاتړ
- **کلیپبورډ ته کاپي** - استخراج شوی متن په اسانۍ سره کاپي کړئ

#### 🏷️ QR کوډونه او بارکوډونه
- **د QR کوډ جوړول** - له URL، متن یا د اړیکو معلوماتو څخه QR کوډونه جوړ کړئ
- **د بارکوډ ملاتړ** - CODE128، CODE39، EAN-13، UPC، ITF-14 جوړ کړئ
- **په PDF کې ځای پرځای کول** - کوډونه په ځانګړو مخونو کې د دودیز موقعیت سره کېږدئ

#### 🎨 واټرمارک او برانډینګ
- **متني واټرمارک** - د فونټ، اندازې او رنګ سره دودیز متن اضافه کړئ
- **انځوریز واټرمارک** - انځورونه یا لوګو کېږدئ
- **د شفافیت کنټرول** - د نرم برانډینګ لپاره شفافیت تنظیم کړئ

#### 📄 د مخونو شمیره
- **سرلیک او فوټر** - د مخ شمیره، سرلیک او فوټر اضافه کړئ
- **دودیز فارمیټونه** - "مخ X له Y"، "X/Y" او نور
- **موقعیت** - پورته، ښکته، کیڼ، ښي یا منځ

#### 📱 د سندونو سکین
- **د کامرې یوځای کول** - سندونه مستقیم له خپل وسیلې کامرې څخه سکین کړئ
- **ډیری مخونو سکین** - ډیری مخونه په پرله پسې ډول سکین کړئ
- **سمدستي PDF** - سکینونه سمدستي PDF ته بدل کړئ

---

## 🔒 محرمیت او امنیت

### ستاسو معلومات خوندي دي

- **۱۰۰٪ د کارونکي اړخ پروسس**: ټول فایل عملیات ستاسو په براوزر کې د WebAssembly او JavaScript سره ترسره کیږي
- **سرور ته اپلوډ نشته**: ستاسو فایلونه هیڅکله ستاسو وسیله نه پریږدي
- **د معلوماتو راټولول نشته**: موږ ستاسو فایلونه نه تعقیبوو، نه ذخیره کوو، نه تحلیل کوو
- **حساب ته اړتیا نشته**: پرته له ثبت نام، پرته له شخصي معلوماتو
- **خلاص سرچینه**: بشپړ شفافیت - پخپله کوډ وګورئ

---

## 📦 کارول

### لومړی اختیار: آنلاین کارول (سپارښتنه)

په ساده ډول [د اپلیکیشن لینک](https://rahmatsaeedi.github.io/herati-stitch-pdf/) ته لاړ شئ او سمدستي کارول پیل کړئ. نصب ته اړتیا نشته!

### دوهم اختیار: د PWA په توګه نصب

۱. په خپل براوزر کې ویب اپلیکیشن ته لاړ شئ
۲. د پتې په بار کې د **نصب** تڼۍ کلیک وکړئ
۳. اپلیکیشن به ستاسو په وسیله نصب شي او آفلاین به شتون ولري

---

## 🌟 د دې پروژې ملاتړ

که تاسو دا پروژه ګټوره ومومئ، مهرباني وکړئ په پام کې ونیسئ:
- ⭐ ریپوزیتري ته ستوری ورکول
- 🐛 د بګونو او ستونزو راپور ورکول
- 💡 د نویو ځانګړتیاوو وړاندیز
- 🔀 د کوډ ښه والي کې برخه اخیستل
- 📢 له نورو سره شریکول

---

<div align="center">

**د Blazor WebAssembly په کارولو سره د ❤️ سره جوړ شوی**

</div>

</div>

---

# English

# Stitch PDF Converter & Merger

<div align="center">

![Stitch PDF Logo](wwwroot/icon-192.png)

**A powerful, privacy-first PDF manipulation tool that runs entirely in your browser**

[![.NET 10](https://img.shields.io/badge/.NET-10-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
[![Blazor WebAssembly](https://img.shields.io/badge/Blazor-WebAssembly-512BD4?logo=blazor)](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
[![PWA](https://img.shields.io/badge/PWA-enabled-5A0FC8?logo=pwa)](https://web.dev/progressive-web-apps/)
[![No Server Required](https://img.shields.io/badge/server-not%20required-success)](https://github.com)

[Features](#-features) • [Usage](#-usage) • [Privacy](#-privacy--security)

</div>

---

## 🎯 Overview

**Stitch PDF** is a modern, feature-rich PDF manipulation tool built as a Progressive Web App (PWA) using Blazor WebAssembly. Unlike traditional PDF tools, Stitch processes everything **100% client-side** — your files never leave your browser, ensuring complete privacy and security.

Whether you need to merge PDFs, convert documents to PDF, add signatures, extract text with OCR, or apply watermarks, Stitch does it all without requiring an internet connection or server uploads.

### Why Stitch?

- **🔒 Privacy First** - All processing happens in your browser. Your files stay on your device.
- **⚡ Lightning Fast** - No server round-trips. Process files instantly.
- **📴 Works Offline** - Install as a PWA and use without internet connectivity.
- **💰 Completely Free** - No subscriptions, no uploads, no limits.
- **🌍 Universal Access** - Works on any device with a modern browser.
- **🎨 Beautiful UI** - Modern Material Design interface with dark mode support.

---

## ✨ Features

### 🔧 Core Functionality

#### PDF Operations
- **Merge PDFs** - Combine multiple PDF files into a single document
- **Split PDFs** - Extract specific pages or split into multiple files
- **Delete Pages** - Remove unwanted pages from PDFs
- **Rotate Pages** - Rotate individual pages or entire documents (90°, 180°, 270°)
- **Reorder Pages** - Drag and drop to rearrange page order
- **Compress PDFs** - Reduce file size with adjustable quality settings
- **Password Protection** - Encrypt PDFs with user and owner passwords
- **Edit Metadata** - Update title, author, subject, keywords, and dates

#### Document Conversion
Convert the following formats to PDF:
- **Office Documents**: DOCX, XLSX, XLS, ODS
- **Raster Images**: PNG, JPG, JPEG, WebP, GIF, BMP, TIFF, AVIF, HEIC/HEIF
- **Vector Graphics**: SVG
- **Text Formats**: TXT, Markdown, CSV, HTML, XML, JSON
- **Archives**: ZIP (extracts and processes all contained files)
- **E-Books**: EPUB

#### Image Export
- **PDF to Images** - Convert PDF pages to PNG or JPG format
- **Batch Export** - Export all pages or selected ranges
- **Quality Control** - Adjustable image quality and resolution

### 🚀 Advanced Features

#### ✍️ E-Signature
- **Draw Signatures** - Freehand drawing with mouse or touch
- **Type Signatures** - Multiple font styles and sizes
- **Upload Signatures** - Use existing signature images
- **Signature Library** - Save and reuse signatures (stored locally)
- **Flexible Placement** - Position signatures anywhere on any page

#### 🔍 OCR (Optical Character Recognition)
- **Text Extraction** - Extract text from images and scanned PDFs using Tesseract.js
- **110+ Languages** - Support for English, Spanish, French, German, Chinese, Japanese, Arabic, and more
- **Searchable PDFs** - Add invisible text layers to make scanned documents searchable
- **Copy to Clipboard** - Easily copy extracted text
- **Confidence Scores** - See OCR accuracy ratings

#### 🏷️ QR Codes & Barcodes
- **QR Code Generation** - Create QR codes from URLs, text, or contact information
- **Barcode Support** - Generate CODE128, CODE39, EAN-13, UPC, ITF-14 barcodes
- **PDF Embedding** - Place codes on specific pages with custom positioning
- **Live Preview** - See codes before embedding
- **Customization** - Adjust size, position, and styling

#### 🎨 Watermarking & Branding
- **Text Watermarks** - Add custom text with font, size, and color options
- **Image Watermarks** - Overlay images or logos
- **Flexible Positioning** - Place watermarks anywhere on the page
- **Opacity Control** - Adjust transparency for subtle branding
- **Rotation** - Angle watermarks diagonally or at custom degrees

#### 📄 Page Numbering
- **Headers & Footers** - Add page numbers, headers, and footers
- **Custom Formats** - "Page X of Y", "X/Y", numbered lists, etc.
- **Positioning** - Top, bottom, left, right, or centered
- **Font Customization** - Choose fonts, sizes, and colors
- **Page Ranges** - Apply to specific pages or entire document

#### 📱 Document Scanning
- **Camera Integration** - Scan documents directly from your device camera
- **Auto-Crop** - Automatically detect document edges
- **Multi-Page Scans** - Scan multiple pages in sequence
- **Instant PDF** - Convert scans to PDF immediately

### 🎯 User Experience

- **Drag & Drop Interface** - Intuitive file upload with visual feedback
- **Live Thumbnails** - Preview all pages before processing
- **Real-time Progress** - See processing status for large operations
- **Recent Files** - Quick access to previously processed files
- **Templates** - Pre-configured document templates for common tasks
- **Batch Operations** - Process multiple files with the same settings
- **Keyboard Shortcuts** - Power user shortcuts for common actions
- **Touch Gestures** - Mobile-optimized touch controls
- **Dark Mode** - Easy on the eyes with automatic theme switching
- **Responsive Design** - Works perfectly on desktop, tablet, and mobile

### ⚙️ Performance & Optimization

- **Memory Monitoring** - Track browser memory usage during operations
- **Chunked Processing** - Handle large files efficiently
- **Web Workers** - Background processing for smooth UI
- **Performance Settings** - Tune memory usage and processing speed
- **File Validation** - Comprehensive type and size validation
- **Error Recovery** - Graceful handling of processing errors

---

## 📦 Usage

### Option 1: Use Online (Recommended)

Simply visit your [deployed URL](https://rahmatsaeedi.github.io/herati-stitch-pdf/) and start using Stitch immediately. No installation required!

### Option 2: Install as PWA

1. Visit the web app in your browser
2. Click the **Install** button in the address bar (or use the in-app install prompt)
3. The app will be installed on your device and available offline

---

## 🎓 Usage

### Basic Workflow

1. **Upload Files**
   - Drag and drop files onto the upload zone
   - Click to browse and select files
   - Or paste images from clipboard

2. **Arrange & Configure**
   - Drag files to reorder them
   - Rotate individual pages
   - Select specific pages from PDFs
   - Configure conversion options (page size, margins, orientation)

3. **Apply Advanced Features** (Optional)
   - Add signatures
   - Extract text with OCR
   - Add watermarks or page numbers
   - Embed QR codes or barcodes
   - Split or compress PDFs

4. **Process & Download**
   - Click "Merge to PDF" or appropriate action button
   - Wait for processing (with real-time progress)
   - Download your processed file

### Keyboard Shortcuts

| Shortcut | Action |
|----------|--------|
| `Ctrl/Cmd + O` | Open file picker |
| `Ctrl/Cmd + S` | Download result |
| `Ctrl/Cmd + M` | Start merge |
| `Ctrl/Cmd + D` | Toggle dark mode |
| `Delete` | Remove selected file |
| `Esc` | Close dialogs |

### Tips & Tricks

- **Large Files**: For files over 100MB, enable chunked processing in Performance Settings
- **Mobile Scanning**: Use the camera scanner for quick document digitization
- **Reusable Signatures**: Save your signature once and reuse it across documents
- **Templates**: Create templates for frequently used document configurations
- **Batch Mode**: Process multiple files with the same watermark or page numbers
- **ZIP Archives**: Upload a ZIP file to automatically extract and process all files inside

---

## 🛠️ Technology Stack

### Frontend Framework
- **[Blazor WebAssembly](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)** - .NET 10 running in the browser via WebAssembly
- **[MudBlazor](https://mudblazor.com/)** - Material Design component library (v8.15.0)
- **C#** - Strongly-typed, modern language for UI logic

### PDF Processing
- **[pdf-lib](https://pdf-lib.js.org/)** - Core PDF creation and manipulation
- **[PDF.js](https://mozilla.github.io/pdf.js/)** - Mozilla's PDF rendering engine for thumbnails
- **[Tesseract.js](https://tesseract.projectnaptha.com/)** - OCR with 110+ language support

### Additional Libraries
- **[Signature Pad](https://github.com/szimek/signature_pad)** - HTML5 canvas-based signature drawing
- **[JsBarcode](https://github.com/lindell/JsBarcode)** - Barcode generation
- **[qrcode.js](https://davidshimjs.github.io/qrcodejs/)** - QR code generation
- **[Mammoth.js](https://github.com/mwilliamson/mammoth.js)** - DOCX to HTML conversion
- **[XLSX.js](https://sheetjs.com/)** - Excel file processing
- **[heic2any](https://github.com/alexcorvi/heic2any)** - HEIC/HEIF image conversion (iPhone photos)
- **[JSZip](https://stuk.github.io/jszip/)** - ZIP archive handling
- **[Sortable.js](https://sortablejs.github.io/Sortable/)** - Drag-and-drop functionality
- **[Marked.js](https://marked.js.org/)** - Markdown parsing
- **[PapaParse](https://www.papaparse.com/)** - CSV parsing
- **[html2canvas](https://html2canvas.hertzen.com/)** - HTML to image conversion

### Architecture
- **Service-Oriented**: Clean separation of concerns with dependency injection
- **JavaScript Interop**: Seamless C#/JavaScript integration for optimal performance
- **Web Workers**: Background processing for responsive UI
- **Progressive Web App**: Service workers for offline support and installation

---

## 📐 Architecture

### Project Structure

```
PdfMerger.Client/
├── Components/
│   └── Shared/              # 28 Reusable Razor components
│       ├── FileUploadZone.razor
│       ├── SignatureDialog.razor
│       ├── OcrDialog.razor
│       ├── QRBarcodeDialog.razor
│       ├── WatermarkDialog.razor
│       └── [23 more components]
├── Models/                  # Data models and DTOs
│   ├── FileItem.cs
│   ├── ProcessingResult.cs
│   ├── PdfConversionOptions.cs
│   └── [10+ more models]
├── Services/                # Business logic and PDF operations
│   ├── IPdfService.cs / PdfService.cs
│   ├── IAdvancedPdfService.cs / AdvancedPdfService.cs
│   ├── ISignatureService.cs / SignatureService.cs
│   ├── IOcrService.cs / OcrService.cs
│   └── [15+ more services]
├── Pages/
│   └── Home.razor           # Main application page
├── wwwroot/
│   ├── js/                  # JavaScript interop modules (15+ files)
│   ├── lib/                 # Third-party libraries (20+ files)
│   ├── css/                 # Stylesheets
│   ├── manifest.json        # PWA manifest
│   ├── service-worker.js    # Service worker for offline support
│   └── index.html           # Entry point
└── Program.cs               # App configuration and DI setup
```

### Service Layer

All functionality is organized into focused services:

- **IPdfService** - Core PDF merge and conversion
- **IAdvancedPdfService** - Split, compress, watermark, page numbers
- **ISignatureService** - E-signature creation and management
- **IOcrService** - Text extraction with Tesseract.js
- **IFileValidationService** - File type and size validation
- **IDocumentConversionService** - DOCX, XLSX, Markdown conversion
- **IRecentFilesService** - Recent files history
- **IBatchOperationsService** - Batch processing workflows
- **ITemplateService** - Document template management
- **IThemeService** - Dark/light theme switching
- **IMemoryMonitorService** - Browser memory tracking
- **IWebWorkerService** - Web Worker management

---

## 🔒 Privacy & Security

### Your Data is Safe

- **100% Client-Side Processing**: All file operations happen in your browser using WebAssembly and JavaScript
- **No Server Uploads**: Your files never leave your device
- **No Data Collection**: We don't track, store, or analyze your files
- **No Account Required**: No sign-ups, no personal information needed
- **Open Source**: Full transparency - inspect the code yourself

### Security Features

- **HTTPS Only**: Enforced in production environments
- **Password Protection**: AES encryption for sensitive PDFs
- **Local Storage Only**: Signatures and templates stored in browser localStorage
- **No External APIs**: All functionality is self-contained
- **Content Security Policy**: Strict CSP headers prevent XSS attacks

### Privacy Best Practices

- **Clear Recent Files**: Regularly clear your recent files history
- **Incognito Mode**: Use private browsing for sensitive documents
- **Self-Host**: Deploy your own instance for complete control

---

## 📊 File Limits

Current configuration (adjustable in `FileValidationService.cs`):

- **Maximum Individual File Size**: 1 GB
- **Maximum Total Upload Size**: 4 GB
- **Recommended File Size**: Under 100 MB for optimal performance
- **Pages per PDF**: Unlimited (memory permitting)

*For large files, enable chunked processing in Performance Settings*

**Note**: The default README mentions 50MB/200MB limits, but the codebase supports up to 1GB/4GB. Adjust `MaxFileSizeBytes` and `MaxTotalSizeBytes` in `Services/FileValidationService.cs` as needed.

---

## 🗺️ Roadmap

### Completed Features ✅

- [x] Core PDF merge and conversion
- [x] E-signature support with drawing, typing, and uploading
- [x] OCR text extraction with 110+ languages
- [x] QR codes and barcodes generation
- [x] Watermarking (text and image)
- [x] Page numbering with custom formats
- [x] PDF splitting and page extraction
- [x] Password protection and encryption
- [x] PDF compression
- [x] PWA with offline support
- [x] Dark mode
- [x] Recent files history
- [x] Batch operations
- [x] Document templates
- [x] Camera scanning
- [x] Performance monitoring and tuning
- [x] Multi-language localization (10 languages including RTL support)

---

## 🤝 Contributing

Contributions are welcome! Whether it's bug fixes, new features, or documentation improvements, your help is appreciated.

### Development Guidelines

- **Code Style**: Follow C# and JavaScript best practices
- **Comments**: Document complex logic and public APIs
- **Testing**: Ensure all features work in Chrome, Firefox, Safari, and Edge
- **Accessibility**: Maintain WCAG 2.1 AA compliance
- **Performance**: Test with large files (500MB+)

### Reporting Bugs

Found a bug? Please open an issue with:
- Description of the bug
- Steps to reproduce
- Expected vs actual behavior
- Browser and OS information
- File types and sizes involved

---


## 🙏 Acknowledgments

This project is built on the shoulders of giants. Special thanks to:

- **[pdf-lib](https://pdf-lib.js.org/)** - Andrew Dillon for the excellent PDF library
- **[PDF.js](https://mozilla.github.io/pdf.js/)** - Mozilla for PDF rendering
- **[Tesseract.js](https://tesseract.projectnaptha.com/)** - Tesseract OCR team
- **[MudBlazor](https://mudblazor.com/)** - MudBlazor team for beautiful components
- **[Blazor Team](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)** - Microsoft for Blazor WebAssembly
- All open-source library authors and contributors

---

## 📞 Support

### Get Help

- **Issues**: [Report a Bug](https://github.com/RahmatSaeedi/herati-stitch-pdf/issues)
- **Discussions**: [Community Forum](https://github.com/RahmatSaeedi/herati-stitch-pdf/discussions)

### Frequently Asked Questions

**Q: Is my data really private?**
A: Yes! All processing happens in your browser. Your files never leave your device.

**Q: Do I need internet to use this?**
A: After the first visit, you can install it as a PWA and use it completely offline.

**Q: What's the maximum file size?**
A: Individual files up to 1GB, total upload up to 4GB. For best performance, keep files under 100MB.

**Q: Which browsers are supported?**
A: All modern browsers: Chrome 90+, Firefox 88+, Edge 90+, Safari 14+ (desktop and mobile).

**Q: Can I use this for commercial purposes?**
A: Yes! The MIT license allows commercial use.

**Q: How do I report a security vulnerability?**
A: Please create a private security advisory on GitHub rather than a public issue.

---

## 🌟 Support This Project

If you find this project useful, please consider:
- ⭐ Starring the repository
- 🐛 Reporting bugs and issues
- 💡 Suggesting new features
- 🔀 Contributing code improvements
- 📢 Sharing with others

---

<div align="center">

**Made with ❤️ using Blazor WebAssembly**

[⬆ Back to Top](#stitch-pdf-converter--merger)

</div>
