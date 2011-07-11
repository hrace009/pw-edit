type = struct RECIPE_ESSENCE {
    unsigned int id;
    unsigned int id_major_type;
    unsigned int id_sub_type;
    namechar name[32];
    int recipe_level;
    unsigned int id_skill;
    int skill_level;
    struct {
        unsigned int id_to_make;
        float probability;
    } targets[4];
    float fail_probability;
    int num_to_make;
    int price;
    float duration;
    int exp;
    int skillpoint;
    struct {
        unsigned int id;
        int num;
    } materials[32];
}
