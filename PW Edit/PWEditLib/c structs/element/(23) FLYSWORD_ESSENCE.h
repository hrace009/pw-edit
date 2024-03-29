type = struct FLYSWORD_ESSENCE {
    unsigned int id;
    namechar name[32];
    char file_model[128];
    char file_matter[128];
    char file_icon[128];
    int price;
    int shop_price;
    int level;
    int require_player_level_min;
    float speed_increase_min;
    float speed_increase_max;
    float speed_rush_increase_min;
    float speed_rush_increase_max;
    float time_max_min;
    float time_max_max;
    float time_increase_per_element;
    unsigned int fly_mode;
    unsigned int character_combo_id;
    int pile_num_max;
    unsigned int has_guid;
    unsigned int proc_type;
}
