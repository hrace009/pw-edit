type = struct DYE_TICKET_ESSENCE {
    unsigned int id;
    namechar name[32];
    char file_matter[128];
    char file_icon[128];
    float h_min;
    float h_max;
    float s_min;
    float s_max;
    float v_min;
    float v_max;
    int price;
    int shop_price;
    int pile_num_max;
    unsigned int has_guid;
    unsigned int proc_type;
}
