﻿using System;
using System.Windows.Forms;

namespace L.E.N.I.N
{
    public partial class PasswordFrame : Form
    {
        public PasswordFrame()
        {
            InitializeComponent();
        }

        private void PasswordFrame_Load(object sender, EventArgs e)
        {
            ControlBox = false;
        }

        readonly string[] citates =
        {
            "Смысла жизни не существует, мне придётся самому создавать его!",

            "Всякая крайность нехороша; все благое и полезное, доведенное до крайности, может стать и даже, за известным пределом, обязательно становится злом и вредом.",

            "Пока есть государство, нет свободы. Когда будет свобода, не будет государства.",

            "Выбор возможен в одном направлении, но невозможно не выбирать.",

            "Лучше умереть стоя, чем жить на коленях.",

            "Пусть родина смотрит на вас с гордостью. Не бойтесь славной смерти. Умереть за родину - значит жить.",

            "Если театр начинается с вешалки, то за такие пьесы нужно вешать.",

            "Победа — это упорство.",

            "Бейте в площади бунтов топот!\r\nВыше, гордых голов гряда!\r\nМы разливом второго потопа\r\nперемоем миров города.\r\n\r\nДней бык пег.\r\nМедленна лет арба.\r\nНаш бог бег.\r\nСердце наш барабан.\r\n\r\nЕсть ли наших золот небесней?\r\nНас ли сжалит пули оса?\r\nНаше оружие – наши песни.\r\nНаше золото – звенящие голоса.\r\n\r\nЗеленью ляг, луг,\r\nвыстели дно дням.\r\nРадуга, дай дуг\r\nлет быстролётным коням.\r\n\r\nВидите, скушно звезд небу!\r\nБез него наши песни вьем.\r\nЭй, Большая Медведица! требуй,\r\nчтоб на небо нас взяли живьем.\r\n\r\nРадости пей! Пой!\r\nВ жилах весна разлита.\r\nСердце, бей бой!\r\nГрудь наша – медь литавр.",

            "Я — маленький хозяин… Очень хорошо! Но от меня кормится сотня рабочих, вместе с их семьями. Если у меня идут хорошо дела — они первые от этого выигрывают, но если я вынужден закрыть завод — вуаля: они на улице. Я не имею права, — сказал он, подчеркивая каждое слово, — плохо вести дела. Вот это, по-моему, и есть «классовая солидарность».",

            "Рабочий!\r\nГлупость беспартийную выкинь!\r\nЕсли хочешь жить с другими вразброд – \r\nвсех по очереди словит Деникин,\r\nвсех сожрёт генеральский рот.\r\n\r\nЕсли ж на зов партийной недели\r\nпридут миллионы с фабрик и с пашен – \r\nрабочий быстро докажет на деле,\r\nчто коммунистам никто не страшен.",

            "Один палец легко сломать, но пять пальцев — это кулак!",

            "Провокация - испытанное средство контрреволюции.",

            "Я начинал революцию, имея за собой 82 человека. Если бы мне пришлось повторить это, мне бы хватило пятнадцати или даже десяти. Десять человек и абсолютная вера. Неважно, сколько вас. Важно верить и важно иметь четкий план.",

            "Если у вас начинается дрожь негодования при каждой несправедливости, то вы мой товарищ.",

            "В жизни нужно идти только вперед. Мы живем в такое время, когда ценность представляет только борющийся человек.",

            "Если я скажу, что вижу смысл жизни в борьбе за дело рабочего класса, то вы вряд ли поймете меня…",

            "Пора сказать решительно и бесповоротно, что с врагами нужно биться, а не соглашаться",

            "Искусство принадлежит народу. Оно должно уходить своими глубочайшими корнями в самую толщу широких трудящихся масс. Оно должно объединять чувство, мысль и волю этих масс, подымать их. Оно должно пробуждать в них художников и развивать их",

            "Капиталисты готовы продать нам веревку, на которой мы их повесим",

            "Мы должны бороться с религией. Это - азбука всего материализма и, следовательно, марксизма. Но марксизм не есть материализм, остановившийся на азбуке. Марксизм идет дальше. Он говорит: надо уметь бороться с религией, а для этого надо материалистически объяснить источник веры и религии у масс",

            "Никто не повинен в том, если он родился рабом; но раб, который не только чуждается стремления к своей свободе, но оправдывает и приукрашивает свое рабство, такой раб есть вызывающий законное чувство негодования, презрения и омерзения холуй и хам",

            "Мы ставим своей конечной целью уничтожение государства, т. е. всякого организованного и систематического насилия, всякого насилия над людьми вообще. Мы не ждем пришествия такого общественного порядка, когда бы не соблюдался принцип подчинения меньшинства большинству. Но, стремясь к социализму, мы убеждены, что он будет перерастать в коммунизм, а в связи с этим будет исчезать всякая надобность в насилии над людьми вообще, в подчинении одного человека другому, одной части населения другой его части, ибо люди привыкнут к соблюдению элементарных условий общественности без насилия и без подчинения.",

            "Смена буржуазного государства пролетарским невозможна без насильственной революции. Уничтожение пролетарского государства, т. е. уничтожение всякого государства, невозможно иначе, как путем «отмирания».",

            "Всякие бывают люди на свете, всякие бывают деятели на свете. Есть люди, о которых не скажешь, кто он такой, то ли он хорош, то ли он плох, то ли мужественен, то ли трусоват, то ли он за народ до конца, то ли он за врагов народа. Есть такие люди и есть такие деятели. Они имеются и у нас, среди большевиков. Сами знаете, товарищи, семья не без урода. О таких людях неопределённого типа, о людях, которые напоминают скорее политических обывателей, чем политических деятелей, о людях такого неопределённого, неоформленного типа довольно метко сказал великий русский писатель Гоголь: «Люди, говорит, неопределённые, ни то, ни сё, не поймёшь, что за люди, ни в городе Богдан, ни в селе Селифан». О таких неопределённых людях и деятелях также довольно метко говорится у нас в народе: «так себе человек — ни рыба, ни мясо», «ни Богу свечка, ни чёрту кочерга.»",

            "Необходимо разбить и отбросить прочь гнилую теорию о том, что с каждым нашим продвижением вперёд классовая борьба у нас должна будто бы всё более и более затухать, что по мере наших успехов классовый враг становится будто бы всё более и более ручным. Это не только гнилая теория, но и опасная теория, ибо она усыпляет наших людей, заводит их в капкан, а классовому врагу даёт возможность оправиться для борьбы с Советской властью. Наоборот, чем больше будем продвигаться вперёд, чем больше будем иметь успехов, тем больше будут озлобляться остатки разбитых эксплуататорских классов, тем скорее будут они идти на более острые формы борьбы, тем больше они будут пакостить Советскому государству, тем больше они будут хвататься за самые отчаянные средства борьбы как последние средства обреченных. Надо иметь в виду, что остатки разбитых классов в СССР не одиноки. Они имеют прямую поддержку со стороны наших врагов за пределами СССР. Ошибочно было бы думать, что сфера классовой борьбы ограничена пределами СССР. Если один конец классовой борьбы имеет своё действие в рамках СССР, то другой её конец протягивается в пределы окружающих нас буржуазных государств. Об этом не могут не знать остатки разбитых классов. И именно потому, что они об этом знают, они будут и впредь продолжать свои отчаянные вылазки.",

            "Воспитание без всестороннего обогащения собственного жизненного опыта — абсурд.",

            "Если судьба особенно склонна к человеку и хочет одарить его величайшим счастьем на свете, она дает ему верных друзей."
        };

        private int GetRandomNumber(string[] array)
        {
            int[] randomNumbers = new int[5];

            for (int i = 0; i < randomNumbers.Length; ++i)
            {
                Random random = new Random();

                randomNumbers[i] = random.Next(0, array.Length);
            }

            Random rand = new Random();

            return randomNumbers[rand.Next(0, 5)];
        }

        private void buttonToReturn_Click(object sender, EventArgs e)
        {
            if (textPassword.Text == "1917" || textPassword.Text == "1922")
            {
                truePass yes = new truePass();

                yes.Show();
            }
            else
            {
                if (textPassword.Text != "") MessageBox.Show(citates[GetRandomNumber(citates)]);
                
                textPassword.Text = "";
            }
        }
    }
}