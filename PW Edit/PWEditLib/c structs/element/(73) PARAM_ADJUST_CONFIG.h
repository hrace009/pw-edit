type = struct PARAM_ADJUST_CONFIG {
    unsigned int id;
    namechar name[32];
    struct {
        int level_diff;
        float adjust_exp;
        float adjust_sp;
        float adjust_money;
        float adjust_matter;
        float adjust_attack;
    } level_diff_adjust[16];
    struct {
        float adjust_exp;
        float adjust_sp;
    } team_adjust[11];
    struct {
        float adjust_exp;
        float adjust_sp;
    } team_profession_adjust[9];
}
