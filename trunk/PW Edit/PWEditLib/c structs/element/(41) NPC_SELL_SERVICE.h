type = struct NPC_SELL_SERVICE {
    unsigned int id;
    namechar name[32];
    struct {
        namechar page_title[8];
        unsigned int id_goods[32];
    } pages[8];
    unsigned int id_dialog;
}
