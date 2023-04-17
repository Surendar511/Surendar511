using System.ServiceModel;
using System.ServiceModel.Web;
using System.Collections.Generic;

namespace FinWebRESTService
{

    [ServiceContract]
    public interface FinWebApics
    {

        //To Insert or POST Records
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/AddPayee", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Customer> AddPayee(Customer customer);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/ping_cocd", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> ping_cocd(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/loginAndroid", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> loginAndroid(Team team);

        //[OperationContract]
        //[WebInvoke(Method = "POST", UriTemplate = "/loginAndwork", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        //List<Team> loginAndwork(Team6 team6);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/loginAndwork", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> loginAndwork(Team6 team6);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/loginScan", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> loginScan(Team team);        
        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/seek_iname", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> seek_iname(Team team);
        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Opencon", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> Opencon(Team team);
        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/execute_transaction", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> execute_transaction(Team team);
        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Getlist", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> Getlist(Team team);
        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/SendEmail", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> SendEmail(Team team);
        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/chk_pk", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> chk_pk(Team team);
        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/execute_cmd_img", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> execute_cmd_img(Team team);
        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/login", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> login(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/showdata", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> showdata(Team team);
        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/seek_iname_multi", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> seek_iname_multi(Team team);
        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Getlist_sale", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> Getlist_sale(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/avg_aname", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> avg_aname(Team6 team6);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/finsys_feed", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> finsys_feed(Team6 team6);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/avg_lastsrate", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> avg_lastsrate(Team team);
        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/avg_item", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> avg_item(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/avg_so_ent", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> avg_so_ent(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/avg_so_10ent", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> avg_so_10ent(Team10 team10);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aSorder_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aSorder_ins(Team team);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aFG173C_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aFG173C_ins(Team team);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/prod_entry", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> prod_entry(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/avg_emp_phone", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> avg_emp_phone(Team6 team6);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/avg_emp_attn", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> avg_emp_attn(Team6 team6);
 
        //[OperationContract]
        //[WebInvoke(Method = "POST", UriTemplate = "/aLeave_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        //List<Team> aLeave_ins(Team team);
 
        //------------------------------------------------------------------------------
        // API For Phone App
        //------------------------------------------------------------------------------
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/login_api", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> login_api(Team team);
        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Menu_api", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> Menu_api(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/DataListA_api", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> DataListA_api(Team6 team6);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/DataListB_api", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> DataListB_api(Team6 team6);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/DataListC_api", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> DataListC_api(Team6 team6);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/DataGraph_api", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> DataGraph_api(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/PendAppr_api", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> PendAppr_api(Team6 team6);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/ApprAction_api", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> ApprAction_api(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/SaveFeebk_api", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> SaveFeebk_api(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/RateHist_api", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> RateHist_api(Team6 team6);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/PassChg_api", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> PassChg_api(Team team);
        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/chkyr_Start_api", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> chkyr_Start_api(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/dbd_info_api", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> dbd_info_api(Team6 team6);
        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/reg_mail_api", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> reg_mail_api(Team team);

        //------------------------------------------------------------------------------
        // new menus api 15/06/2021 onwards
        //------------------------------------------------------------------------------


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Mob_Opt_api", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> Mob_Opt_api(Team6 team6);

        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Menu_hrapi", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> Menu_hrapi(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Menu_smapi", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> Menu_smapi(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Menu_strapi", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> Menu_strapi(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Menu_Mtnapi", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> Menu_Mtnapi(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Menu_Prdapi", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> Menu_Prdapi(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Menu_Logiapi", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> Menu_Logiapi(Team team);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Menu_Gateapi", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> Menu_Gateapi(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Menu_Commapi", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> Menu_Commapi(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Menu_Qrinvapi", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> Menu_Qrinvapi(Team team);

        //------------------------------------------------------------------------------
        // module wise dbd 15/06/2021 onwards

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Dbd_smapi", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> Dbd_smapi(Team6 team6);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Dbd_hrapi", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> Dbd_hrapi(Team6 team6);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Dbd_strapi", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> Dbd_strapi(Team6 team6);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Dbd_Mtnapi", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> Dbd_Mtnapi(Team6 team6);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Dbd_Prdapi", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> Dbd_Prdapi(Team6 team6);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Dbd_Logiapi", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> Dbd_Logiapi(Team6 team6);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Dbd_Gateapi", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> Dbd_Gateapi(Team6 team6);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Dbd_Commapi", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> Dbd_Commapi(Team6 team6);
        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Dbd_Qrinvapi", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> Dbd_Qrinvapi(Team6 team6);
        
        //------------------------------------------------------------------------------
        // new write api 15/06/2021 onwards

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aLeave_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aLeave_ins(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aLoan_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aLoan_ins(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aAdvance_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aAdvance_ins(Team team);

        //------------------------------------------------------------------------------
        // new write api 15/06/2021 onwards
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aSmvisit_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aSmvisit_ins(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aSmexp_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aSmexp_ins(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aSlead_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aSlead_ins(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/afinudf_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> afinudf_ins(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aEmpattn_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aEmpattn_ins(Team team);

        //------------------------------------------------------------------------------
        // new write api 15/06/2021 onwards

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aIssReq_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aIssReq_ins(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aIssEntry_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aIssEntry_ins(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aphystk_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aphystk_ins(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/asset_ver_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> asset_ver_ins(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/apowcon_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> apowcon_ins(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/areel_check", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> areel_check(Team6 team6);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/areel_FGRcheck", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> areel_FGRcheck(Team6 team6);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/areel_jccheck", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> areel_jccheck(Team6 team6);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/areel_retcheck", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> areel_retcheck(Team6 team6);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aNJreel_jccheck", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> aNJreel_jccheck(Team6 team6);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aNJ_NR_jccheck", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> aNJ_NR_jccheck(Team6 team6);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aNJ_NR_PHcheck", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> aNJ_NR_PHcheck(Team6 team6);

        

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aNJreel_retcheck", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> aNJreel_retcheck(Team6 team6);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/ajobc_check", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> ajobc_check(Team6 team6);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aSGFG_check", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> aSGFG_check(Team6 team6);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aFGTAG_check", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> aFGTAG_check(Team6 team6);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aMCTAG_check", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> aMCTAG_check(Team6 team6);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aJOB_START", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aJOB_START(Team team);
        


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aFGTAG_stack", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aFGTAG_stack(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aSV_MRRIQC_upd", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aSV_MRRIQC_upd(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aREEL_stack", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aREEL_stack(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/bom_updated", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> bom_updated(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aBUPL_BOM", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<BOMlist> aBUPL_BOM(Team6 team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/areel_issue", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> areel_issue(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/comman_method", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> comman_method(Team6 team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/MVIN_Dispatch_Note", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> MVIN_Dispatch_Note(Team team);
        

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/areel_issue_MJ", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> areel_issue_MJ(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aPurReq_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aPurReq_ins(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aCure_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aCure_ins(Team team);

        

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aEATMAKE_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aEATMAKE_ins(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aDownREJ_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aDownREJ_ins(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aCure_check", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> aCure_check(Team6 team6);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/saveBytesImg", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> saveBytesImg(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/saveImageNew", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> saveImageNew(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aLogis_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aLogis_ins(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aMaintcomp_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aMaintcomp_ins(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aMaintsolv_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aMaintsolv_ins(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/amaintspare_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> amaintspare_ins(Team team);


        //------------------------------------------------------------------------------
        // new write api 06/08/2021 onwards

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aVisitio_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aVisitio_ins(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aSomas_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aSomas_ins(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aSomasQ_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aSomasQ_ins(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aDnote_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aDnote_ins(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aSalsch_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aSalsch_ins(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/afinoms_act", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> afinoms_act(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aPuroms_act", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aPuroms_act(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aCrmcont_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aCrmcont_ins(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aInterStg_check", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team6> aInterStg_check(Team6 team6);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aInterStg_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aInterStg_ins(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aBasprod_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aBasprod_ins(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aInvchlOut_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aInvchlOut_ins(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aCrmFolo_act", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aCrmFolo_act(Team team);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/aprodmw_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Team> aprodmw_ins(Team team);
        
        //[OperationContract]
        //[WebInvoke(Method = "POST", UriTemplate = "/aStaffout_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        //List<Team> aStaffout_ins(Team team);


        //[OperationContract]
        //[WebInvoke(Method = "POST", UriTemplate = "/aprodstd_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        //List<Team> aprodstd_ins(Team team);

        //[OperationContract]
        //[WebInvoke(Method = "POST", UriTemplate = "/abasicqa_ins", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        //List<Team> abasicqa_ins(Team team);

        //------------------------------------------------------------------------------

        ////To Get Records from database 
        //[OperationContract]
        //[WebInvoke(Method = "GET",UriTemplate = "/PayBill/{PayId}", BodyStyle = WebMessageBodyStyle.Wrapped,RequestFormat = WebMessageFormat.Json,ResponseFormat = WebMessageFormat.Json)]
        //string PayBill(string PayId);

        ////To Update records
        //[OperationContract]
        //[WebInvoke(Method = "PUT", UriTemplate = "/UpdateBillPayment/{PayId}/{TransId}", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        //void UpdateBillPayment(string PayId,string TransId);

        ////To delete records
        //[OperationContract]
        //[WebInvoke(Method = "DELETE", UriTemplate = "/RemovePayee/{Id}", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        //void RemovePayee(string Id);

    }
}
