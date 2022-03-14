//
//Названия необходимых шаблонов указаны в кавычках
//
//Например в строке {ViewTemplateName.FACADE_VIEW_FRONT_VIEW,"DNS_F_Плитка"}, будет искаться шаблон в проекте с названием "DNS_F_Плитка"
//
//При наличии в проекте шаблона с названием "DNS_F_Плитка1" или любым другим, совпадающим по маске с "*DNS_F_Плитка*" будет выбран первый попавшийся
//

//
		//Типы семейств для листов
//
		//При наличии совпадающих названий типов, будет использован первый
//
            {ViewTemplateName.SHEET_FORM_4_TITLE, "Форма 4_чертил"},
            {ViewTemplateName.SHEET_FORM_6, "Форма 6"},
//
//
		//Шаблоны 3D видов
//
		//При отсутствии необходимого шаблона, будет создан вид без шаблона
//
            {ViewTemplateName.SLAB_3D_VIEW , "3D_Плита перекрытия"},
            {ViewTemplateName.PANEL_3D_VIEW , "3D_Стеновая панель"},
//
//
		//Шаблоны видов и сечений
//
		//При отсутствии необходимого шаблона, будет создан вид без шаблона
//
//
            {ViewTemplateName.FACADE_VIEW_FRONT_VIEW,"DNS_F_Плитка"},
            {ViewTemplateName.WALL_MESH_FRONT_VIEW,"DNS_КЖ_О_Р_Сетка арматурная"},
            {ViewTemplateName.WALL_MESH_INTERNAL_FRONT_VIEW,"DNS_КЖ_О_Р_Сетка арматурная_Внутренний слой"},
            {ViewTemplateName.WALL_MESH_OUTER_FRONT_VIEW,"DNS_КЖ_О_Р_Сетка арматурная_Наружный слой" },
            {ViewTemplateName.WALL_REBAR_FRONT_VIEW,"DNS_КЖ_О_Р_Стеновые панели_Армирование"},
            {ViewTemplateName.WALL_REBAR_INTERNAL_FRONT_VIEW,"DNS_КЖ_О_Р_Стеновые панели_Армирование_Внутренний слой"},
            {ViewTemplateName.WALL_REBAR_INTERNAL_SECTION_VIEW,"DNS_КЖ_О_Р_Стеновые панели_Армирование_Внутренний слой_Сечение"},
            {ViewTemplateName.WALL_REBAR_OUTER_FRONT_VIEW,"DNS_КЖ_О_Р_Стеновые панели_Армирование_Наружный слой"},
            {ViewTemplateName.WALL_REBAR_OUTER_SECTION_VIEW,"DNS_КЖ_О_Р_Стеновые панели_Армирование_Наружный слой_Сечение"},
            {ViewTemplateName.WALL_REBAR_SECTION_VIEW,"DNS_КЖ_О_Р_Стеновые панели_Армирование_Сечение"},
            {ViewTemplateName.WALL_JOINT_FRONT_VIEW,"DNS_КЖ_О_Р_Стеновые панели_Бийски"},
            {ViewTemplateName.WALL_JOINT_SECTION_VIEW,"DNS_КЖ_О_Р_Стеновые панели_Бийски_Сечение"},
            {ViewTemplateName.WALL_CASING_FRONT_VIEW,"DNS_КЖ_О_Р_Стеновые панели_Опалубка"},
            {ViewTemplateName.WALL_CASING_SECTION_VIEW,"DNS_КЖ_О_Р_Стеновые панели_Опалубка_Сечение"},
            {ViewTemplateName.WALL_INSULATION_FRONT_VIEW,"DNS_КЖ_О_Р_Стеновые панели_Утеплитель"},

            {ViewTemplateName.BALCONY_REBAR_FRONT_VIEW,  "DNS_КЖИ_О_Р_Плиты балконные_Армирование"},
            {ViewTemplateName.BALCONY_REBAR_SECTION_VIEW,  "DNS_КЖИ_О_Р_Плиты балконные_Армирование_Сечение"},
            {ViewTemplateName.BALCONY_CASING_PLAN_VIEW,  "DNS_КЖИ_О_Р_Плиты балконные_Опалубка"},
            {ViewTemplateName.BALCONY_CASING_SECTION_VIEW,  "DNS_КЖИ_О_Р_Плиты балконные_Опалубка_Сечение"},

            {ViewTemplateName.SLAB_PLAN_VIEW,  "П_Плита перекрытия"},
            {ViewTemplateName.SLAB_SECTION_VIEW,  "Р_Плита перекрытия"},
//
//
		//Легенды
//
		//При отсутствии какой-либо из легенд, необходимой для создания видов - она не будет размещена
//
            {ViewTemplateName.LEGEND_ORIENTATION_ANNOTATION, "Обозначение_Символ ориентации"},
            {ViewTemplateName.LEGEND_WALL_OUTER_JOINT_ANNOTATION , "Обозначения_Бийски панелей НС"},
            {ViewTemplateName.LEGEND_WALL_OUTER_JOINT_DESCRIPTION,"Примечание_Бийски панелей НС" },

            {ViewTemplateName.LEGEND_WALL_OUTER_CASING_ANNOTATION,  "Примечание_НС_Лист 2"},
            {ViewTemplateName.LEGEND_WALL_OUTER_INSULATION_ANNOTATION,  "Примечание_НС_Лист 3"},
            {ViewTemplateName.LEGEND_WALL_OUTER_INSULATION_GRAPHIC_ANNOTATION,  "Обозначение_НС_Лист 3"},
            {ViewTemplateName.LEGEND_WALL_OUTER_REBAR_INNER_ANNOTATION,  "Примечание_НС_Лист 5"},
            {ViewTemplateName.LEGEND_WALL_OUTER_REBAR_OUTER_ANNOTATION,  "Примечание_НС_Лист 6"},
            {ViewTemplateName.LEGEND_WALL_OUTER_SCHEDULE_ANNOTATION,  "Примечание_НС_Лист 7"},
            {ViewTemplateName.LEGEND_WALL_OUTER_MESH_INNER_ANNOTATION,  "Примечание_НС_Лист 8"},
            {ViewTemplateName.LEGEND_WALL_OUTER_MESH_OUTER_ANNOTATION,  "Примечание_НС_Лист 9"},

            {ViewTemplateName.LEGEND_WALL_INNER_CASING_ANNOTATION,  "Примечание_ВС_Лист 2"},
            {ViewTemplateName.LEGEND_WALL_INNER_REBAR_ANNOTATION,  "Примечание_ВС_Лист 3"},
            {ViewTemplateName.LEGEND_WALL_INNER_MESH_ANNOTATION,  "Примечание_ВС_Лист 5"},

            {ViewTemplateName.LEGEND_BALCONY_CASING_ANNOTATION,  "Примечание_БП_Лист 2"},
            {ViewTemplateName.LEGEND_PARAPET_CASING_ANNOTATION,  "Примечание_ПС_Лист 2"},
            {ViewTemplateName.LEGEND_BEND_DETAILS_ANNOTATION,  "Эскиз_Деталей_Гнутых"},

            {ViewTemplateName.LEGEND_WALL_INNER_DESCRIPTION,"Обозначения_Панели стеновые внутренние"},
            {ViewTemplateName.LEGEND_WALL_OUTER_DESCRIPTION,  "Обозначения_Панели стеновые наружные"},
            {ViewTemplateName.LEGEND_PARAPET_DESCRIPTION,  "Обозначения_Панели стеновые парапетные"},
            {ViewTemplateName.LEGEND_WALL_INNER_ANNOTATION,  "Примечание_Панели стеновые внутренние"},
            {ViewTemplateName.LEGEND_WALL_OUTER_ANNOTATION,  "Примечание_Панели стеновые наружные"},
            {ViewTemplateName.LEGEND_PARAPET_ANNOTATION,  "Примечание_Панели стеновые парапетные"},

            {ViewTemplateName.LEGEND_FACADE_ANNOTATION,  "АКР примечание"},
            {ViewTemplateName.LEGEND_FACADE_LAYOUT_SCHEME,  "Схема раскладки плитки (рядовая панель)"},
            {ViewTemplateName.LEGEND_FACADE_DESCRIPTION,  "Условные обозначения"},
//
//
		//Шаблоны спецификаций
//
		//При отсутствии необходимого шаблона, будет создана спецификация без шаблона
//
//
            {ViewTemplateName.SCHEDULE_WALL_INSULATION_WOOL , "М_Минвата"},
            {ViewTemplateName.SCHEDULE_WALL_CONCRETE_VOLUME , "М_Панель стеновая"},

            {ViewTemplateName.SCHEDULE_BALCONY_CONCRETE_VOLUME , "М_Плита балконная"},

            {ViewTemplateName.SCHEDULE_SLAB_CONCRETE_VOLUME, "М_Плита перекрытия"},
            {ViewTemplateName.SCHEDULE_WALL_INSULATION_XPS,"М_Полистирол"},

            {ViewTemplateName.SCHEDULE_BALCONY_REINFORCEMENT, "СА_Балконная плита"},

            {ViewTemplateName.SCHEDULE_WALL_REINFORCEMENT_MASS,  "СА_Масса_Панель стеновая"},
            {ViewTemplateName.SCHEDULE_WALL_REINFORCEMENT,  "СА_Панель стеновая"},
            {ViewTemplateName.SCHEDULE_SLAB_REINFORCEMENT,  "СА_Плита перекрытия"},
            {ViewTemplateName.SCHEDULE_WALL_MESH_REINFORCEMENT,  "СА_Сетка арматурная"},
            {ViewTemplateName.SCHEDULE_WALL_MESH_INTERNAL_REINFORCEMENT,  "СА_Сетка арматурная_Внутренний слой"},
            {ViewTemplateName.SCHEDULE_WALL_MESH_OUTER_REINFORCEMENT,  "СА_Сетка арматурная_Наружный слой"},

            {ViewTemplateName.SCHEDULE_BALCONY_CASING,  "СЗД_Балконная плита"},
            {ViewTemplateName.SCHEDULE_PARAPET_CASING,  "СЗД_Панель парапета"},
            {ViewTemplateName.SCHEDULE_WALL_CASING,  "СЗД_Панель стеновая"},

            {ViewTemplateName.SCHEDULE_BALCONY_REINFORCEMENT_TYPES,  "СТА_Балконная плита"},
            {ViewTemplateName.SCHEDULE_WALL_REINFORCEMENT_TYPES,  "СТА_Панель стеновая"},
			
            {ViewTemplateName.SCHEDULE_FACADE,  "DNS_Ф_Плитка"},
            {ViewTemplateName.SCHEDULE_FACADE_TYPES,  "DNS_Марки_Плитка"}
