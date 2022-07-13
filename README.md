# dvRAT
<div dir="rtl">


بسم الله الرحمن الرحيم

مشروع : dvRAT\
نسخة : 0.0.1 تجريبية

----------------------------------------------------------------------------------------------------------------------------------------------------------------

دڤرات هو عبارة عن مشروع يتكون من سيرفر وبرمجية خبيثة تقوم بالتحكم بها عن طريق السيرفر بإرسال أوامر لها وهي تقوم بالتنفيذ .

----------------------------------------------------------------------------------------------------------------------------------------------------------------

# معلومات عن المشروع

البيئة التطويرية الخاصة بالمشروع: Visual Studio
\
اللغات البرمجية المستعملة في المشروع: C#, C
\
إسم السليوشن الخاصة بالمشروع: dvRAT
\
إسم المشروع الخاص بالسيرفر: CSServer
\
إسم المشروع الخاص بالكلاينت: Cclient



# مسارات المشروع

(السليوشن) dvrat.sln 
\
(مجلد الحاوي للمشروع) Server/ 
\
"يحتوي بداخله ايضا على ملفات الاكواد الخاصه بالسيرفر وايضا الكلاينت لكن الكلاينت يوجد في ملف اخر داخله"
\
\
(المجلد ال resources) Server/res 
\
"يحتوي على ايقونات وملفات يتم استعمالها من السيرفر اثناء التشغيل وايضا يحتوي على المشروع الخاص بالبرمجية الخبيثه او الكلاينت"
\
\
(المجلد الحاوي لمشروع وملفات البرمجية الخبيثة) Server/res/Client 
\
"يحتوي هذا الملف على الاكواد ومشروع البرمجية الخبيثة"

# اسألة محتمله

- لماذا يوجد مشروع البرمجية الخبيثة في ملف مرجعي / resource؟

- بشكل مبسط لأن الكود الخاص بالبرمجية الخبيثه يفترض ان يتم بنائه من خلال برنامج السيرفر وتخصيص بعض المعلومات مثل المستضيف(HOST) و المنفذ(PORT) من خلال السيرفر ثم يتم وضعها في الكود لكن هذا سيكون في النسخه النهائية وليس في النسخ التجريبية .

- ما التقدم الذي احرزته في المشروع للان؟

- افضل تقدم احرزته هو اني اضفت خاصية تصفح الملفات في جهاز الضحية ليست بالشكل الكامل او الي اتمناه لكن شيء احسن من لاشيء .

# أهداف المشروع

1- تغيير العادة والفكرة النمطية لبرامج ال RAT انها تكون مبرمجة بلغات عالية المستوى مثل .Net او Python في هذا المشروع البرمجية الخبيثة بالكامل مبرمجة بلغة C بدون استعمال اي مكتبة طرف ثالث .

2- يكون المشروع مطورينه عرب فقط والتحديثات المكتوبه عنه باللغة العربية .
  
3- جعل المشروع متكامل او بعبارة اخرى يحتوي على ماقد تضنه يوجد في برمجية خبيثة مثل اضافة استغلالات للويندوز لرفع الصلاحيات(توجد فعلا في البرمجية لكن ذكرتها كمثال) او استغلالات لأنظمة الحماية وهكذا...

# شرح مبسط للملفات

مجلد Server/\
"هذا المجلد يتم وضع فيه الواجهات الرسومية او بمعنى اخر الملفات الأساسية والتي تلعب دور مهم في البرنامج"\
مجلد Server/modules/\
"هنا يتم وضع الملفات التي يتم استعمالها وبنائها بشكل مخصص ولا تلعب دور مهم في البرنامج يتم استعمالها لغرض مخصص فقط مثل rename_dialog.cs تم بنائه لغرض مخصص فقط . "\
ملف Server/Form1.cs\
"الملف الأساسي و الذي يحتوي على الفنكشنز الخاصة بالسيرفر من حيث ادارة الكلاينت و إرسال و إستقبال رسائل من والى الكلاينت وطبعا يحتوي على فنكشنز لإدارة الواجهة الرسومية" \
مجلد Server/res/Client/ \
"المجلد الحاوي على ملفات البرمجية الخبيثة"\
ملف Server/res/Client/main.c\
"الملف الاساسي الذي يحتوي اكواد البرمجية الخبيثة ونقطة الانطلاق هي WinMain وبذلك تعرف ان البرنامج عباره عن Windows app وليس Console app"

# كيف يمكنك أن تساعد ؟

`مادام أن الكود لايزال في مراحلة الاولى تستطيع و أنا أحثك على إقتناص الفرصة وتعديل او تصحيح الاخطاء او اضافة افكار جديدة ووضع إسمك في ملف المشاركين`
- أبحث عن فكرة رأيتها في برنامج RAT واعجبتك واقتبسها وضعها في الكود او ارسلها لي كإقتراح !
- قم بعمل clone للبرنامج في جهازك و إقرأ الكود وابحث عن انماط متكرره يمكن اختصارها وقم بذلك !
- إبحث عن اخطاء لغوية او طريقة تكويد سيئة وقم بتحسينها !\
و هكذا ...
</div>
