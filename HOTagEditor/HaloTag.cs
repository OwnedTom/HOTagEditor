using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using System.IO;

namespace HOTagEditor
{
    class HaloTagCol
    {
        private List<fxTag> fxTags;
        private List<achiTag> achiTags;
        private List<adlgTag> adlgTags;
        private List<aiglTag> aiglTags;
        private List<antTag> antTags;
        private List<armsTag> armsTags;
        private List<beamTag> beamTags;
        private List<binkTag> binkTags;
        private List<bipdTag> bipdTags;
        private List<bitmTag> bitmTags;
        private List<bkeyTag> bkeyTags;
        private List<blocTag> blocTags;
        private List<bmp3Tag> bmp3Tags;
        private List<bsdtTag> bsdtTags;
        private List<cddfTag> cddfTags;
        private List<cfgtTag> cfgtTags;
        private List<cfxsTag> cfxsTags;
        private List<chadTag> chadTags;
        private List<char_Tag> charTags;
        private List<chdtTag> chdtTags;
        private List<chgdTag> chgdTags;
        private List<chmtTag> chmtTags;
        private List<clwdTag> clwdTags;
        private List<cmoeTag> cmoeTags;
        private List<cntlTag> cntlTags;
        private List<collTag> collTags;
        private List<coloTag> coloTags;
        private List<cprlTag> cprlTags;
        private List<creaTag> creaTags;
        private List<dctrTag> dctrTags;
        private List<decsTag> decsTags;
        private List<drawTag> drawTags;
        private List<drdfTag> drdfTags;
        private List<dsrcTag> dsrcTags;
        private List<effeTag> effeTags;
        private List<effgTag> effgTags;
        private List<efscTag> efscTags;
        private List<eqipTag> eqipTags;
        private List<flckTag> flckTags;
        private List<footTag> footTags;
        private List<formTag> formTags;
        private List<gfxtTag> gfxtTags;
        private List<glpsTag> glpsTags;
        private List<glvsTag> glvsTags;
        private List<goofTag> goofTags;
        private List<gpdtTag> gpdtTags;
        private List<grupTag> grupTags;
        private List<hlmtTag> hlmtTags;
        private List<inpgTag> inpgTags;
        private List<jmadTag> jmadTags;
        private List<jmrqTag> jmrqTags;
        private List<jptTag> jptTags;
        private List<LbspTag> LbspTags;
        private List<lensTag> lensTags;
        private List<lighTag> lighTags;
        private List<lsndTag> lsndTags;
        private List<lst3Tag> lst3Tags;
        private List<ltvlTag> ltvlTags;
        private List<machTag> machTags;
        private List<matgTag> matgTags;
        private List<mdl3Tag> mdl3Tags;
        private List<mffnTag> mffnTags;
        private List<modeTag> modeTags;
        private List<mulgTag> mulgTags;
        private List<pdmTag> pdmTags;
        private List<perfTag> perfTags;
        private List<phmoTag> phmoTags;
        private List<pixlTag> pixlTags;
        private List<pmdfTag> pmdfTags;
        private List<pmovTag> pmovTags;
        private List<pphyTag> pphyTags;
        private List<projTag> projTags;
        private List<prt3Tag> prt3Tags;
        private List<rasgTag> rasgTags;
        private List<rmdTag> rmdTags;
        private List<rmdfTag> rmdfTags;
        private List<rmflTag> rmflTags;
        private List<rmhgTag> rmhgTags;
        private List<rmopTag> rmopTags;
        private List<rmshTag> rmshTags;
        private List<rmssTag> rmssTags;
        private List<rmt2Tag> rmt2Tags;
        private List<rmtrTag> rmtrTags;
        private List<rmwTag> rmwTags;
        private List<rmzoTag> rmzoTags;
        private List<rwrdTag> rwrdTags;
        private List<sbspTag> sbspTags;
        private List<scenTag> scenTags;
        private List<scn3Tag> scn3Tags;
        private List<scnrTag> scnrTags;
        private List<sddtTag> sddtTags;
        private List<sefcTag> sefcTags;
        private List<sfxTag> sfxTags;
        private List<sgpTag> sgpTags;
        private List<shitTag> shitTags;
        private List<silyTag> silyTags;
        private List<skn3Tag> skn3Tags;
        private List<skyaTag> skyaTags;
        private List<sLdTTag> sLdTTags;
        private List<smdtTag> smdtTags;
        private List<snclTag> snclTags;
        private List<sndTag> sndTags;
        private List<sndeTag> sndeTags;
        private List<snmxTag> snmxTags;
        private List<spkTag> spkTags;
        private List<sqtmTag> sqtmTags;
        private List<ssceTag> ssceTags;
        private List<stylTag> stylTags;
        private List<susTag> susTags;
        private List<trakTag> trakTags;
        private List<trdfTag> trdfTags;
        private List<txt3Tag> txt3Tags;
        private List<udlgTag> udlgTags;
        private List<uiseTag> uiseTags;
        private List<unicTag> unicTags;
        private List<vehiTag> vehiTags;
        private List<vfslTag> vfslTags;
        private List<vmdxTag> vmdxTags;
        private List<vtshTag> vtshTags;
        private List<wacdTag> wacdTags;
        private List<wclrTag> wclrTags;
        private List<weapTag> weapTags;
        private List<wezrTag> wezrTags;
        private List<wganTag> wganTags;
        private List<wgtzTag> wgtzTags;
        private List<wiglTag> wiglTags;
        private List<windTag> windTags;
        private List<wposTag> wposTags;
        private List<wrotTag> wrotTags;
        private List<wsclTag> wsclTags;
        private List<wsprTag> wsprTags;
        private List<wtuvTag> wtuvTags;

        public HaloTagCol()
        {
            this.fxTags = new List<fxTag>();
            this.achiTags = new List<achiTag>();
            this.adlgTags = new List<adlgTag>();
            this.aiglTags = new List<aiglTag>();
            this.antTags = new List<antTag>();
            this.armsTags = new List<armsTag>();
            this.beamTags = new List<beamTag>();
            this.binkTags = new List<binkTag>();
            this.bipdTags = new List<bipdTag>();
            this.bitmTags = new List<bitmTag>();
            this.bkeyTags = new List<bkeyTag>();
            this.blocTags = new List<blocTag>();
            this.bmp3Tags = new List<bmp3Tag>();
            this.bsdtTags = new List<bsdtTag>();
            this.cddfTags = new List<cddfTag>();
            this.cfgtTags = new List<cfgtTag>();
            this.cfxsTags = new List<cfxsTag>();
            this.chadTags = new List<chadTag>();
            this.charTags = new List<char_Tag>();
            this.chdtTags = new List<chdtTag>();
            this.chgdTags = new List<chgdTag>();
            this.chmtTags = new List<chmtTag>();
            this.clwdTags = new List<clwdTag>();
            this.cmoeTags = new List<cmoeTag>();
            this.cntlTags = new List<cntlTag>();
            this.collTags = new List<collTag>();
            this.coloTags = new List<coloTag>();
            this.cprlTags = new List<cprlTag>();
            this.creaTags = new List<creaTag>();
            this.dctrTags = new List<dctrTag>();
            this.decsTags = new List<decsTag>();
            this.drawTags = new List<drawTag>();
            this.drdfTags = new List<drdfTag>();
            this.dsrcTags = new List<dsrcTag>();
            this.effeTags = new List<effeTag>();
            this.effgTags = new List<effgTag>();
            this.efscTags = new List<efscTag>();
            this.eqipTags = new List<eqipTag>();
            this.flckTags = new List<flckTag>();
            this.footTags = new List<footTag>();
            this.formTags = new List<formTag>();
            this.gfxtTags = new List<gfxtTag>();
            this.glpsTags = new List<glpsTag>();
            this.glvsTags = new List<glvsTag>();
            this.goofTags = new List<goofTag>();
            this.gpdtTags = new List<gpdtTag>();
            this.grupTags = new List<grupTag>();
            this.hlmtTags = new List<hlmtTag>();
            this.inpgTags = new List<inpgTag>();
            this.jmadTags = new List<jmadTag>();
            this.jmrqTags = new List<jmrqTag>();
            this.jptTags = new List<jptTag>();
            this.LbspTags = new List<LbspTag>();
            this.lensTags = new List<lensTag>();
            this.lighTags = new List<lighTag>();
            this.lsndTags = new List<lsndTag>();
            this.lst3Tags = new List<lst3Tag>();
            this.ltvlTags = new List<ltvlTag>();
            this.machTags = new List<machTag>();
            this.matgTags = new List<matgTag>();
            this.mdl3Tags = new List<mdl3Tag>();
            this.mffnTags = new List<mffnTag>();
            this.modeTags = new List<modeTag>();
            this.mulgTags = new List<mulgTag>();
            this.pdmTags = new List<pdmTag>();
            this.perfTags = new List<perfTag>();
            this.phmoTags = new List<phmoTag>();
            this.pixlTags = new List<pixlTag>();
            this.pmdfTags = new List<pmdfTag>();
            this.pmovTags = new List<pmovTag>();
            this.pphyTags = new List<pphyTag>();
            this.projTags = new List<projTag>();
            this.prt3Tags = new List<prt3Tag>();
            this.rasgTags = new List<rasgTag>();
            this.rmdTags = new List<rmdTag>();
            this.rmdfTags = new List<rmdfTag>();
            this.rmflTags = new List<rmflTag>();
            this.rmhgTags = new List<rmhgTag>();
            this.rmopTags = new List<rmopTag>();
            this.rmshTags = new List<rmshTag>();
            this.rmssTags = new List<rmssTag>();
            this.rmt2Tags = new List<rmt2Tag>();
            this.rmtrTags = new List<rmtrTag>();
            this.rmwTags = new List<rmwTag>();
            this.rmzoTags = new List<rmzoTag>();
            this.rwrdTags = new List<rwrdTag>();
            this.sbspTags = new List<sbspTag>();
            this.scenTags = new List<scenTag>();
            this.scn3Tags = new List<scn3Tag>();
            this.scnrTags = new List<scnrTag>();
            this.sddtTags = new List<sddtTag>();
            this.sefcTags = new List<sefcTag>();
            this.sfxTags = new List<sfxTag>();
            this.sgpTags = new List<sgpTag>();
            this.shitTags = new List<shitTag>();
            this.silyTags = new List<silyTag>();
            this.skn3Tags = new List<skn3Tag>();
            this.skyaTags = new List<skyaTag>();
            this.sLdTTags = new List<sLdTTag>();
            this.smdtTags = new List<smdtTag>();
            this.snclTags = new List<snclTag>();
            this.sndTags = new List<sndTag>();
            this.sndeTags = new List<sndeTag>();
            this.snmxTags = new List<snmxTag>();
            this.spkTags = new List<spkTag>();
            this.sqtmTags = new List<sqtmTag>();
            this.ssceTags = new List<ssceTag>();
            this.stylTags = new List<stylTag>();
            this.susTags = new List<susTag>();
            this.trakTags = new List<trakTag>();
            this.trdfTags = new List<trdfTag>();
            this.txt3Tags = new List<txt3Tag>();
            this.udlgTags = new List<udlgTag>();
            this.uiseTags = new List<uiseTag>();
            this.unicTags = new List<unicTag>();
            this.vehiTags = new List<vehiTag>();
            this.vfslTags = new List<vfslTag>();
            this.vmdxTags = new List<vmdxTag>();
            this.vtshTags = new List<vtshTag>();
            this.wacdTags = new List<wacdTag>();
            this.wclrTags = new List<wclrTag>();
            this.weapTags = new List<weapTag>();
            this.wezrTags = new List<wezrTag>();
            this.wganTags = new List<wganTag>();
            this.wgtzTags = new List<wgtzTag>();
            this.wiglTags = new List<wiglTag>();
            this.windTags = new List<windTag>();
            this.wposTags = new List<wposTag>();
            this.wrotTags = new List<wrotTag>();
            this.wsclTags = new List<wsclTag>();
            this.wsprTags = new List<wsprTag>();
            this.wtuvTags = new List<wtuvTag>();
        }

        public void addTag(HaloTag tag)
        {
            switch(tag.getType())
            {
                case globals.tagType.fx: fxTags.Add((fxTag)tag); break;
                case globals.tagType.achi: achiTags.Add((achiTag)tag); break;
                case globals.tagType.adlg: adlgTags.Add((adlgTag)tag); break;
                case globals.tagType.aigl: aiglTags.Add((aiglTag)tag); break;
                case globals.tagType.ant: antTags.Add((antTag)tag); break;
                case globals.tagType.arms: armsTags.Add((armsTag)tag); break;
                case globals.tagType.beam: beamTags.Add((beamTag)tag); break;
                case globals.tagType.bink: binkTags.Add((binkTag)tag); break;
                case globals.tagType.bipd: bipdTags.Add((bipdTag)tag); break;
                case globals.tagType.bitm: bitmTags.Add((bitmTag)tag); break;
                case globals.tagType.bkey: bkeyTags.Add((bkeyTag)tag); break;
                case globals.tagType.bloc: blocTags.Add((blocTag)tag); break;
                case globals.tagType.bmp3: bmp3Tags.Add((bmp3Tag)tag); break;
                case globals.tagType.bsdt: bsdtTags.Add((bsdtTag)tag); break;
                case globals.tagType.cddf: cddfTags.Add((cddfTag)tag); break;
                case globals.tagType.cfgt: cfgtTags.Add((cfgtTag)tag); break;
                case globals.tagType.cfxs: cfxsTags.Add((cfxsTag)tag); break;
                case globals.tagType.chad: chadTags.Add((chadTag)tag); break;
                case globals.tagType.char_: charTags.Add((char_Tag)tag); break;
                case globals.tagType.chdt: chdtTags.Add((chdtTag)tag); break;
                case globals.tagType.chgd: chgdTags.Add((chgdTag)tag); break;
                case globals.tagType.chmt: chmtTags.Add((chmtTag)tag); break;
                case globals.tagType.clwd: clwdTags.Add((clwdTag)tag); break;
                case globals.tagType.cmoe: cmoeTags.Add((cmoeTag)tag); break;
                case globals.tagType.cntl: cntlTags.Add((cntlTag)tag); break;
                case globals.tagType.coll: collTags.Add((collTag)tag); break;
                case globals.tagType.colo: coloTags.Add((coloTag)tag); break;
                case globals.tagType.cprl: cprlTags.Add((cprlTag)tag); break;
                case globals.tagType.crea: creaTags.Add((creaTag)tag); break;
                case globals.tagType.dctr: dctrTags.Add((dctrTag)tag); break;
                case globals.tagType.decs: decsTags.Add((decsTag)tag); break;
                case globals.tagType.draw: drawTags.Add((drawTag)tag); break;
                case globals.tagType.drdf: drdfTags.Add((drdfTag)tag); break;
                case globals.tagType.dsrc: dsrcTags.Add((dsrcTag)tag); break;
                case globals.tagType.effe: effeTags.Add((effeTag)tag); break;
                case globals.tagType.effg: effgTags.Add((effgTag)tag); break;
                case globals.tagType.efsc: efscTags.Add((efscTag)tag); break;
                case globals.tagType.eqip: eqipTags.Add((eqipTag)tag); break;
                case globals.tagType.flck: flckTags.Add((flckTag)tag); break;
                case globals.tagType.foot: footTags.Add((footTag)tag); break;
                case globals.tagType.form: formTags.Add((formTag)tag); break;
                case globals.tagType.gfxt: gfxtTags.Add((gfxtTag)tag); break;
                case globals.tagType.glps: glpsTags.Add((glpsTag)tag); break;
                case globals.tagType.glvs: glvsTags.Add((glvsTag)tag); break;
                case globals.tagType.goof: goofTags.Add((goofTag)tag); break;
                case globals.tagType.gpdt: gpdtTags.Add((gpdtTag)tag); break;
                case globals.tagType.grup: grupTags.Add((grupTag)tag); break;
                case globals.tagType.hlmt: hlmtTags.Add((hlmtTag)tag); break;
                case globals.tagType.inpg: inpgTags.Add((inpgTag)tag); break;
                case globals.tagType.jmad: jmadTags.Add((jmadTag)tag); break;
                case globals.tagType.jmrq: jmrqTags.Add((jmrqTag)tag); break;
                case globals.tagType.jpt: jptTags.Add((jptTag)tag); break;
                case globals.tagType.Lbsp: LbspTags.Add((LbspTag)tag); break;
                case globals.tagType.lens: lensTags.Add((lensTag)tag); break;
                case globals.tagType.ligh: lighTags.Add((lighTag)tag); break;
                case globals.tagType.lsnd: lsndTags.Add((lsndTag)tag); break;
                case globals.tagType.lst3: lst3Tags.Add((lst3Tag)tag); break;
                case globals.tagType.ltvl: ltvlTags.Add((ltvlTag)tag); break;
                case globals.tagType.mach: machTags.Add((machTag)tag); break;
                case globals.tagType.matg: matgTags.Add((matgTag)tag); break;
                case globals.tagType.mdl3: mdl3Tags.Add((mdl3Tag)tag); break;
                case globals.tagType.mffn: mffnTags.Add((mffnTag)tag); break;
                case globals.tagType.mode: modeTags.Add((modeTag)tag); break;
                case globals.tagType.mulg: mulgTags.Add((mulgTag)tag); break;
                case globals.tagType.pdm: pdmTags.Add((pdmTag)tag); break;
                case globals.tagType.perf: perfTags.Add((perfTag)tag); break;
                case globals.tagType.phmo: phmoTags.Add((phmoTag)tag); break;
                case globals.tagType.pixl: pixlTags.Add((pixlTag)tag); break;
                case globals.tagType.pmdf: pmdfTags.Add((pmdfTag)tag); break;
                case globals.tagType.pmov: pmovTags.Add((pmovTag)tag); break;
                case globals.tagType.pphy: pphyTags.Add((pphyTag)tag); break;
                case globals.tagType.proj: projTags.Add((projTag)tag); break;
                case globals.tagType.prt3: prt3Tags.Add((prt3Tag)tag); break;
                case globals.tagType.rasg: rasgTags.Add((rasgTag)tag); break;
                case globals.tagType.rmd: rmdTags.Add((rmdTag)tag); break;
                case globals.tagType.rmdf: rmdfTags.Add((rmdfTag)tag); break;
                case globals.tagType.rmfl: rmflTags.Add((rmflTag)tag); break;
                case globals.tagType.rmhg: rmhgTags.Add((rmhgTag)tag); break;
                case globals.tagType.rmop: rmopTags.Add((rmopTag)tag); break;
                case globals.tagType.rmsh: rmshTags.Add((rmshTag)tag); break;
                case globals.tagType.rmss: rmssTags.Add((rmssTag)tag); break;
                case globals.tagType.rmt2: rmt2Tags.Add((rmt2Tag)tag); break;
                case globals.tagType.rmtr: rmtrTags.Add((rmtrTag)tag); break;
                case globals.tagType.rmw: rmwTags.Add((rmwTag)tag); break;
                case globals.tagType.rmzo: rmzoTags.Add((rmzoTag)tag); break;
                case globals.tagType.rwrd: rwrdTags.Add((rwrdTag)tag); break;
                case globals.tagType.sbsp: sbspTags.Add((sbspTag)tag); break;
                case globals.tagType.scen: scenTags.Add((scenTag)tag); break;
                case globals.tagType.scn3: scn3Tags.Add((scn3Tag)tag); break;
                case globals.tagType.scnr: scnrTags.Add((scnrTag)tag); break;
                case globals.tagType.sddt: sddtTags.Add((sddtTag)tag); break;
                case globals.tagType.sefc: sefcTags.Add((sefcTag)tag); break;
                case globals.tagType.sfx: sfxTags.Add((sfxTag)tag); break;
                case globals.tagType.sgp: sgpTags.Add((sgpTag)tag); break;
                case globals.tagType.shit: shitTags.Add((shitTag)tag); break;
                case globals.tagType.sily: silyTags.Add((silyTag)tag); break;
                case globals.tagType.skn3: skn3Tags.Add((skn3Tag)tag); break;
                case globals.tagType.skya: skyaTags.Add((skyaTag)tag); break;
                case globals.tagType.sLdT: sLdTTags.Add((sLdTTag)tag); break;
                case globals.tagType.smdt: smdtTags.Add((smdtTag)tag); break;
                case globals.tagType.sncl: snclTags.Add((snclTag)tag); break;
                case globals.tagType.snd: sndTags.Add((sndTag)tag); break;
                case globals.tagType.snde: sndeTags.Add((sndeTag)tag); break;
                case globals.tagType.snmx: snmxTags.Add((snmxTag)tag); break;
                case globals.tagType.spk: spkTags.Add((spkTag)tag); break;
                case globals.tagType.sqtm: sqtmTags.Add((sqtmTag)tag); break;
                case globals.tagType.ssce: ssceTags.Add((ssceTag)tag); break;
                case globals.tagType.styl: stylTags.Add((stylTag)tag); break;
                case globals.tagType.sus: susTags.Add((susTag)tag); break;
                case globals.tagType.trak: trakTags.Add((trakTag)tag); break;
                case globals.tagType.trdf: trdfTags.Add((trdfTag)tag); break;
                case globals.tagType.txt3: txt3Tags.Add((txt3Tag)tag); break;
                case globals.tagType.udlg: udlgTags.Add((udlgTag)tag); break;
                case globals.tagType.uise: uiseTags.Add((uiseTag)tag); break;
                case globals.tagType.unic: unicTags.Add((unicTag)tag); break;
                case globals.tagType.vehi: vehiTags.Add((vehiTag)tag); break;
                case globals.tagType.vfsl: vfslTags.Add((vfslTag)tag); break;
                case globals.tagType.vmdx: vmdxTags.Add((vmdxTag)tag); break;
                case globals.tagType.vtsh: vtshTags.Add((vtshTag)tag); break;
                case globals.tagType.wacd: wacdTags.Add((wacdTag)tag); break;
                case globals.tagType.wclr: wclrTags.Add((wclrTag)tag); break;
                case globals.tagType.weap: weapTags.Add((weapTag)tag); break;
                case globals.tagType.wezr: wezrTags.Add((wezrTag)tag); break;
                case globals.tagType.wgan: wganTags.Add((wganTag)tag); break;
                case globals.tagType.wgtz: wgtzTags.Add((wgtzTag)tag); break;
                case globals.tagType.wigl: wiglTags.Add((wiglTag)tag); break;
                case globals.tagType.wind: windTags.Add((windTag)tag); break;
                case globals.tagType.wpos: wposTags.Add((wposTag)tag); break;
                case globals.tagType.wrot: wrotTags.Add((wrotTag)tag); break;
                case globals.tagType.wscl: wsclTags.Add((wsclTag)tag); break;
                case globals.tagType.wspr: wsprTags.Add((wsprTag)tag); break;
                case globals.tagType.wtuv: wtuvTags.Add((wtuvTag)tag); break;
            }
        }

        public void setContent(BinaryReader reader)
        {
            foreach (HaloTag tag in fxTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in achiTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in adlgTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in aiglTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in antTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in armsTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in beamTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in binkTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in bipdTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in bitmTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in bkeyTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in blocTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in bmp3Tags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in bsdtTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in cddfTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in cfgtTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in cfxsTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in chadTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in charTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in chdtTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in chgdTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in chmtTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in clwdTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in cmoeTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in cntlTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in collTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in coloTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in cprlTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in creaTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in dctrTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in decsTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in drawTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in drdfTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in dsrcTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in effeTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in effgTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in efscTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in eqipTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in flckTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in footTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in formTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in gfxtTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in glpsTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in glvsTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in goofTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in gpdtTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in grupTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in hlmtTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in inpgTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in jmadTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in jmrqTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in jptTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in LbspTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in lensTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in lighTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in lsndTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in lst3Tags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in ltvlTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in machTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in matgTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in mdl3Tags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in mffnTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in modeTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in mulgTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in pdmTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in perfTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in phmoTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in pixlTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in pmdfTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in pmovTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in pphyTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in projTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in prt3Tags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in rasgTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in rmdTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in rmdfTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in rmflTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in rmhgTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in rmopTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in rmshTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in rmssTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in rmt2Tags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in rmtrTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in rmwTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in rmzoTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in rwrdTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in sbspTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in scenTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in scn3Tags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in scnrTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in sddtTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in sefcTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in sfxTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in sgpTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in shitTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in silyTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in skn3Tags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in skyaTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in sLdTTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in smdtTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in snclTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in sndTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in sndeTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in snmxTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in spkTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in sqtmTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in ssceTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in stylTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in susTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in trakTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in trdfTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in txt3Tags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in udlgTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in uiseTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in unicTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in vehiTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in vfslTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in vmdxTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in vtshTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in wacdTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in wclrTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in weapTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in wezrTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in wganTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in wgtzTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in wiglTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in windTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in wposTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in wrotTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in wsclTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in wsprTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
            foreach (HaloTag tag in wtuvTags) { reader.BaseStream.Position = int.Parse(tag.getOffset(), System.Globalization.NumberStyles.HexNumber); tag.setContents(reader.ReadBytes(int.Parse(tag.getSize(), System.Globalization.NumberStyles.HexNumber))); }
        }

        public List<HaloTag> getTagsList(string tagType)
        {
            switch(tagType)
            {
                case "<fx>": return this.fxTags.Cast<HaloTag>().ToList();
                case "achi": return this.achiTags.Cast<HaloTag>().ToList();
                case "adlg": return this.adlgTags.Cast<HaloTag>().ToList();
                case "aigl": return this.aiglTags.Cast<HaloTag>().ToList();
                case "ant!": return this.antTags.Cast<HaloTag>().ToList();
                case "arms": return this.armsTags.Cast<HaloTag>().ToList();
                case "beam": return this.beamTags.Cast<HaloTag>().ToList();
                case "bink": return this.binkTags.Cast<HaloTag>().ToList();
                case "bipd": return this.bipdTags.Cast<HaloTag>().ToList();
                case "bitm": return this.bitmTags.Cast<HaloTag>().ToList();
                case "bkey": return this.bkeyTags.Cast<HaloTag>().ToList();
                case "bloc": return this.blocTags.Cast<HaloTag>().ToList();
                case "bmp3": return this.bmp3Tags.Cast<HaloTag>().ToList();
                case "bsdt": return this.bsdtTags.Cast<HaloTag>().ToList();
                case "cddf": return this.cddfTags.Cast<HaloTag>().ToList();
                case "cfgt": return this.cfgtTags.Cast<HaloTag>().ToList();
                case "cfxs": return this.cfxsTags.Cast<HaloTag>().ToList();
                case "chad": return this.chadTags.Cast<HaloTag>().ToList();
                case "char": return this.charTags.Cast<HaloTag>().ToList();
                case "chdt": return this.chdtTags.Cast<HaloTag>().ToList();
                case "chgd": return this.chgdTags.Cast<HaloTag>().ToList();
                case "chmt": return this.chmtTags.Cast<HaloTag>().ToList();
                case "clwd": return this.clwdTags.Cast<HaloTag>().ToList();
                case "cmoe": return this.cmoeTags.Cast<HaloTag>().ToList();
                case "cntl": return this.cntlTags.Cast<HaloTag>().ToList();
                case "coll": return this.collTags.Cast<HaloTag>().ToList();
                case "colo": return this.coloTags.Cast<HaloTag>().ToList();
                case "cprl": return this.cprlTags.Cast<HaloTag>().ToList();
                case "crea": return this.creaTags.Cast<HaloTag>().ToList();
                case "dctr": return this.dctrTags.Cast<HaloTag>().ToList();
                case "decs": return this.decsTags.Cast<HaloTag>().ToList();
                case "draw": return this.drawTags.Cast<HaloTag>().ToList();
                case "drdf": return this.drdfTags.Cast<HaloTag>().ToList();
                case "dsrc": return this.dsrcTags.Cast<HaloTag>().ToList();
                case "effe": return this.effeTags.Cast<HaloTag>().ToList();
                case "effg": return this.effgTags.Cast<HaloTag>().ToList();
                case "efsc": return this.efscTags.Cast<HaloTag>().ToList();
                case "eqip": return this.eqipTags.Cast<HaloTag>().ToList();
                case "flck": return this.flckTags.Cast<HaloTag>().ToList();
                case "foot": return this.footTags.Cast<HaloTag>().ToList();
                case "form": return this.formTags.Cast<HaloTag>().ToList();
                case "gfxt": return this.gfxtTags.Cast<HaloTag>().ToList();
                case "glps": return this.glpsTags.Cast<HaloTag>().ToList();
                case "glvs": return this.glvsTags.Cast<HaloTag>().ToList();
                case "goof": return this.goofTags.Cast<HaloTag>().ToList();
                case "gpdt": return this.gpdtTags.Cast<HaloTag>().ToList();
                case "grup": return this.grupTags.Cast<HaloTag>().ToList();
                case "hlmt": return this.hlmtTags.Cast<HaloTag>().ToList();
                case "inpg": return this.inpgTags.Cast<HaloTag>().ToList();
                case "jmad": return this.jmadTags.Cast<HaloTag>().ToList();
                case "jmrq": return this.jmrqTags.Cast<HaloTag>().ToList();
                case "jpt!": return this.jptTags.Cast<HaloTag>().ToList();
                case "Lbsp": return this.LbspTags.Cast<HaloTag>().ToList();
                case "lens": return this.lensTags.Cast<HaloTag>().ToList();
                case "ligh": return this.lighTags.Cast<HaloTag>().ToList();
                case "lsnd": return this.lsndTags.Cast<HaloTag>().ToList();
                case "lst3": return this.lst3Tags.Cast<HaloTag>().ToList();
                case "ltvl": return this.ltvlTags.Cast<HaloTag>().ToList();
                case "mach": return this.machTags.Cast<HaloTag>().ToList();
                case "matg": return this.matgTags.Cast<HaloTag>().ToList();
                case "mdl3": return this.mdl3Tags.Cast<HaloTag>().ToList();
                case "mffn": return this.mffnTags.Cast<HaloTag>().ToList();
                case "mode": return this.modeTags.Cast<HaloTag>().ToList();
                case "mulg": return this.mulgTags.Cast<HaloTag>().ToList();
                case "pdm!": return this.pdmTags.Cast<HaloTag>().ToList();
                case "perf": return this.perfTags.Cast<HaloTag>().ToList();
                case "phmo": return this.phmoTags.Cast<HaloTag>().ToList();
                case "pixl": return this.pixlTags.Cast<HaloTag>().ToList();
                case "pmdf": return this.pmdfTags.Cast<HaloTag>().ToList();
                case "pmov": return this.pmovTags.Cast<HaloTag>().ToList();
                case "pphy": return this.pphyTags.Cast<HaloTag>().ToList();
                case "proj": return this.projTags.Cast<HaloTag>().ToList();
                case "prt3": return this.prt3Tags.Cast<HaloTag>().ToList();
                case "rasg": return this.rasgTags.Cast<HaloTag>().ToList();
                case "rmd": return this.rmdTags.Cast<HaloTag>().ToList();
                case "rmdf": return this.rmdfTags.Cast<HaloTag>().ToList();
                case "rmfl": return this.rmflTags.Cast<HaloTag>().ToList();
                case "rmhg": return this.rmhgTags.Cast<HaloTag>().ToList();
                case "rmop": return this.rmopTags.Cast<HaloTag>().ToList();
                case "rmsh": return this.rmshTags.Cast<HaloTag>().ToList();
                case "rmss": return this.rmssTags.Cast<HaloTag>().ToList();
                case "rmt2": return this.rmt2Tags.Cast<HaloTag>().ToList();
                case "rmtr": return this.rmtrTags.Cast<HaloTag>().ToList();
                case "rmw": return this.rmwTags.Cast<HaloTag>().ToList();
                case "rmzo": return this.rmzoTags.Cast<HaloTag>().ToList();
                case "rwrd": return this.rwrdTags.Cast<HaloTag>().ToList();
                case "sbsp": return this.sbspTags.Cast<HaloTag>().ToList();
                case "scen": return this.scenTags.Cast<HaloTag>().ToList();
                case "scn3": return this.scn3Tags.Cast<HaloTag>().ToList();
                case "scnr": return this.scnrTags.Cast<HaloTag>().ToList();
                case "sddt": return this.sddtTags.Cast<HaloTag>().ToList();
                case "sefc": return this.sefcTags.Cast<HaloTag>().ToList();
                case "sfx+": return this.sfxTags.Cast<HaloTag>().ToList();
                case "sgp!": return this.sgpTags.Cast<HaloTag>().ToList();
                case "shit": return this.shitTags.Cast<HaloTag>().ToList();
                case "sily": return this.silyTags.Cast<HaloTag>().ToList();
                case "skn3": return this.skn3Tags.Cast<HaloTag>().ToList();
                case "skya": return this.skyaTags.Cast<HaloTag>().ToList();
                case "sLdT": return this.sLdTTags.Cast<HaloTag>().ToList();
                case "smdt": return this.smdtTags.Cast<HaloTag>().ToList();
                case "sncl": return this.snclTags.Cast<HaloTag>().ToList();
                case "snd!": return this.sndTags.Cast<HaloTag>().ToList();
                case "snde": return this.sndeTags.Cast<HaloTag>().ToList();
                case "snmx": return this.snmxTags.Cast<HaloTag>().ToList();
                case "spk!": return this.spkTags.Cast<HaloTag>().ToList();
                case "sqtm": return this.sqtmTags.Cast<HaloTag>().ToList();
                case "ssce": return this.ssceTags.Cast<HaloTag>().ToList();
                case "styl": return this.stylTags.Cast<HaloTag>().ToList();
                case "sus!": return this.susTags.Cast<HaloTag>().ToList();
                case "trak": return this.trakTags.Cast<HaloTag>().ToList();
                case "trdf": return this.trdfTags.Cast<HaloTag>().ToList();
                case "txt3": return this.txt3Tags.Cast<HaloTag>().ToList();
                case "udlg": return this.udlgTags.Cast<HaloTag>().ToList();
                case "uise": return this.uiseTags.Cast<HaloTag>().ToList();
                case "unic": return this.unicTags.Cast<HaloTag>().ToList();
                case "vehi": return this.vehiTags.Cast<HaloTag>().ToList();
                case "vfsl": return this.vfslTags.Cast<HaloTag>().ToList();
                case "vmdx": return this.vmdxTags.Cast<HaloTag>().ToList();
                case "vtsh": return this.vtshTags.Cast<HaloTag>().ToList();
                case "wacd": return this.wacdTags.Cast<HaloTag>().ToList();
                case "wclr": return this.wclrTags.Cast<HaloTag>().ToList();
                case "weap": return this.weapTags.Cast<HaloTag>().ToList();
                case "wezr": return this.wezrTags.Cast<HaloTag>().ToList();
                case "wgan": return this.wganTags.Cast<HaloTag>().ToList();
                case "wgtz": return this.wgtzTags.Cast<HaloTag>().ToList();
                case "wigl": return this.wiglTags.Cast<HaloTag>().ToList();
                case "wind": return this.windTags.Cast<HaloTag>().ToList();
                case "wpos": return this.wposTags.Cast<HaloTag>().ToList();
                case "wrot": return this.wrotTags.Cast<HaloTag>().ToList();
                case "wscl": return this.wsclTags.Cast<HaloTag>().ToList();
                case "wspr": return this.wsprTags.Cast<HaloTag>().ToList();
                case "wtuv": return this.wtuvTags.Cast<HaloTag>().ToList();
                default: List<HaloTag> List = new List<HaloTag>(); return List;
            }
        }

        public HaloTag getTag(string offset, string tagType)
        {
            switch (tagType)
            {
                case "<fx>": foreach (HaloTag tag in fxTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "achi": foreach (HaloTag tag in achiTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "adlg": foreach (HaloTag tag in adlgTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "aigl": foreach (HaloTag tag in aiglTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "ant!": foreach (HaloTag tag in antTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "arms": foreach (HaloTag tag in armsTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "beam": foreach (HaloTag tag in beamTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "bink": foreach (HaloTag tag in binkTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "bipd": foreach (HaloTag tag in bipdTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "bitm": foreach (HaloTag tag in bitmTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "bkey": foreach (HaloTag tag in bkeyTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "bloc": foreach (HaloTag tag in blocTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "bmp3": foreach (HaloTag tag in bmp3Tags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "bsdt": foreach (HaloTag tag in bsdtTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "cddf": foreach (HaloTag tag in cddfTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "cfgt": foreach (HaloTag tag in cfgtTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "cfxs": foreach (HaloTag tag in cfxsTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "chad": foreach (HaloTag tag in chadTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "char": foreach (HaloTag tag in charTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "chdt": foreach (HaloTag tag in chdtTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "chgd": foreach (HaloTag tag in chgdTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "chmt": foreach (HaloTag tag in chmtTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "clwd": foreach (HaloTag tag in clwdTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "cmoe": foreach (HaloTag tag in cmoeTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "cntl": foreach (HaloTag tag in cntlTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "coll": foreach (HaloTag tag in collTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "colo": foreach (HaloTag tag in coloTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "cprl": foreach (HaloTag tag in cprlTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "crea": foreach (HaloTag tag in creaTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "dctr": foreach (HaloTag tag in dctrTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "decs": foreach (HaloTag tag in decsTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "draw": foreach (HaloTag tag in drawTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "drdf": foreach (HaloTag tag in drdfTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "dsrc": foreach (HaloTag tag in dsrcTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "effe": foreach (HaloTag tag in effeTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "effg": foreach (HaloTag tag in effgTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "efsc": foreach (HaloTag tag in efscTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "eqip": foreach (HaloTag tag in eqipTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "flck": foreach (HaloTag tag in flckTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "foot": foreach (HaloTag tag in footTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "form": foreach (HaloTag tag in formTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "gfxt": foreach (HaloTag tag in gfxtTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "glps": foreach (HaloTag tag in glpsTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "glvs": foreach (HaloTag tag in glvsTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "goof": foreach (HaloTag tag in goofTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "gpdt": foreach (HaloTag tag in gpdtTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "grup": foreach (HaloTag tag in grupTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "hlmt": foreach (HaloTag tag in hlmtTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "inpg": foreach (HaloTag tag in inpgTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "jmad": foreach (HaloTag tag in jmadTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "jmrq": foreach (HaloTag tag in jmrqTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "jpt!": foreach (HaloTag tag in jptTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "Lbsp": foreach (HaloTag tag in LbspTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "lens": foreach (HaloTag tag in lensTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "ligh": foreach (HaloTag tag in lighTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "lsnd": foreach (HaloTag tag in lsndTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "lst3": foreach (HaloTag tag in lst3Tags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "ltvl": foreach (HaloTag tag in ltvlTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "mach": foreach (HaloTag tag in machTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "matg": foreach (HaloTag tag in matgTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "mdl3": foreach (HaloTag tag in mdl3Tags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "mffn": foreach (HaloTag tag in mffnTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "mode": foreach (HaloTag tag in modeTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "mulg": foreach (HaloTag tag in mulgTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "pdm!": foreach (HaloTag tag in pdmTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "perf": foreach (HaloTag tag in perfTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "phmo": foreach (HaloTag tag in phmoTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "pixl": foreach (HaloTag tag in pixlTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "pmdf": foreach (HaloTag tag in pmdfTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "pmov": foreach (HaloTag tag in pmovTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "pphy": foreach (HaloTag tag in pphyTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "proj": foreach (HaloTag tag in projTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "prt3": foreach (HaloTag tag in prt3Tags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "rasg": foreach (HaloTag tag in rasgTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "rmd": foreach (HaloTag tag in rmdTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "rmdf": foreach (HaloTag tag in rmdfTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "rmfl": foreach (HaloTag tag in rmflTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "rmhg": foreach (HaloTag tag in rmhgTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "rmop": foreach (HaloTag tag in rmopTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "rmsh": foreach (HaloTag tag in rmshTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "rmss": foreach (HaloTag tag in rmssTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "rmt2": foreach (HaloTag tag in rmt2Tags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "rmtr": foreach (HaloTag tag in rmtrTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "rmw": foreach (HaloTag tag in rmwTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "rmzo": foreach (HaloTag tag in rmzoTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "rwrd": foreach (HaloTag tag in rwrdTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "sbsp": foreach (HaloTag tag in sbspTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "scen": foreach (HaloTag tag in scenTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "scn3": foreach (HaloTag tag in scn3Tags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "scnr": foreach (HaloTag tag in scnrTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "sddt": foreach (HaloTag tag in sddtTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "sefc": foreach (HaloTag tag in sefcTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "sfx+": foreach (HaloTag tag in sfxTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "sgp!": foreach (HaloTag tag in sgpTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "shit": foreach (HaloTag tag in shitTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "sily": foreach (HaloTag tag in silyTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "skn3": foreach (HaloTag tag in skn3Tags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "skya": foreach (HaloTag tag in skyaTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "sLdT": foreach (HaloTag tag in sLdTTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "smdt": foreach (HaloTag tag in smdtTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "sncl": foreach (HaloTag tag in snclTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "snd!": foreach (HaloTag tag in sndTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "snde": foreach (HaloTag tag in sndeTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "snmx": foreach (HaloTag tag in snmxTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "spk!": foreach (HaloTag tag in spkTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "sqtm": foreach (HaloTag tag in sqtmTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "ssce": foreach (HaloTag tag in ssceTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "styl": foreach (HaloTag tag in stylTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "sus!": foreach (HaloTag tag in susTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "trak": foreach (HaloTag tag in trakTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "trdf": foreach (HaloTag tag in trdfTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "txt3": foreach (HaloTag tag in txt3Tags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "udlg": foreach (HaloTag tag in udlgTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "uise": foreach (HaloTag tag in uiseTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "unic": foreach (HaloTag tag in unicTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "vehi": foreach (HaloTag tag in vehiTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "vfsl": foreach (HaloTag tag in vfslTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "vmdx": foreach (HaloTag tag in vmdxTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "vtsh": foreach (HaloTag tag in vtshTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "wacd": foreach (HaloTag tag in wacdTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "wclr": foreach (HaloTag tag in wclrTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "weap": foreach (HaloTag tag in weapTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "wezr": foreach (HaloTag tag in wezrTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "wgan": foreach (HaloTag tag in wganTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "wgtz": foreach (HaloTag tag in wgtzTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "wigl": foreach (HaloTag tag in wiglTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "wind": foreach (HaloTag tag in windTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "wpos": foreach (HaloTag tag in wposTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "wrot": foreach (HaloTag tag in wrotTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "wscl": foreach (HaloTag tag in wsclTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "wspr": foreach (HaloTag tag in wsprTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                case "wtuv": foreach (HaloTag tag in wtuvTags) { if (tag.getOffset() == offset) { return tag; } } return new HaloTag("", "", "", "", globals.tagType.fx);
                default: HaloTag emptyTag = new HaloTag("", "", "", "", globals.tagType.fx); return emptyTag;
            }
        }
    }

    class HaloTag
    {
        private globals.tagType tagType;
        private string offset;
        private string size;
        private string name;
        private string displayName;
        private Byte[] contents;

        public HaloTag(string offset, string size, string name, string displayName, globals.tagType type)
        {
            this.offset = offset;
            this.size = size;
            this.name = name;
            this.displayName = displayName;
            this.tagType = type;
        }

        public string getOffset()
        {
            return this.offset;
        }

        public string getSize()
        {
            return this.size;
        }

        public string getName()
        {
            return this.name;
        }

        public string getDisplayName()
        {
            return this.displayName;
        }

        public globals.tagType getType()
        {
            return this.tagType;
        }

        public Byte[] getContents()
        {
            return this.contents;
        }

        public void setContents(Byte[] contents)
        {
            this.contents = contents;
        }
    }

    class patch
    {
        private string offset;
        private Byte[] originalContent;
        private globals.tagType tagType;
        public patch(string offset, Byte[]originalContent, globals.tagType tagType)
        {
            this.offset = offset;
            this.originalContent = originalContent;
            this.tagType = tagType;
        }
    }

    class fxTag : HaloTag
    {
        public fxTag(string offset, string size, string name, string displayName) : base(offset, size, name, displayName, globals.tagType.fx)
        {
         
        }
    }

    class achiTag : HaloTag
    {
        public achiTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.achi)
        {

        }
    }

    class adlgTag : HaloTag
    {
        public adlgTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.adlg)
        {

        }
    }

    class aiglTag : HaloTag
    {
        public aiglTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.aigl)
        {

        }
    }

    class antTag : HaloTag
    {
        public antTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.ant)
        {

        }
    }

    class armsTag : HaloTag
    {
        public armsTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.arms)
        {

        }
    }

    class beamTag : HaloTag
    {
        public beamTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.beam)
        {

        }
    }

    class binkTag : HaloTag
    {
        public binkTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.bink)
        {

        }
    }

    class bipdTag : HaloTag
    {
        public bipdTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.bipd)
        {

        }
    }

    class bitmTag : HaloTag
    {
        public bitmTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.bitm)
        {

        }
    }

    class bkeyTag : HaloTag
    {
        public bkeyTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.bkey)
        {

        }
    }

    class blocTag : HaloTag
    {
        public blocTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.bloc)
        {

        }
    }

    class bmp3Tag : HaloTag
    {
        public bmp3Tag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.bmp3)
        {

        }
    }

    class bsdtTag : HaloTag
    {
        public bsdtTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.bsdt)
        {

        }
    }

    class cddfTag : HaloTag
    {
        public cddfTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.cddf)
        {

        }
    }

    class cfgtTag : HaloTag
    {
        public cfgtTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.cfgt)
        {

        }
    }

    class cfxsTag : HaloTag
    {
        public cfxsTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.cfxs)
        {

        }
    }

    class chadTag : HaloTag
    {
        public chadTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.chad)
        {

        }
    }

    class char_Tag : HaloTag
    {
        public char_Tag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.char_)
        {

        }
    }

    class chdtTag : HaloTag
    {
        public chdtTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.chdt)
        {

        }
    }

    class chgdTag : HaloTag
    {
        public chgdTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.chgd)
        {

        }
    }

    class chmtTag : HaloTag
    {
        public chmtTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.chmt)
        {

        }
    }

    class clwdTag : HaloTag
    {
        public clwdTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.clwd)
        {

        }
    }

    class cmoeTag : HaloTag
    {
        public cmoeTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.cmoe)
        {

        }
    }

    class cntlTag : HaloTag
    {
        public cntlTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.cntl)
        {

        }
    }

    class collTag : HaloTag
    {
        public collTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.coll)
        {

        }
    }

    class coloTag : HaloTag
    {
        public coloTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.colo)
        {

        }
    }

    class cprlTag : HaloTag
    {
        public cprlTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.cprl)
        {

        }
    }

    class creaTag : HaloTag
    {
        public creaTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.crea)
        {

        }
    }

    class dctrTag : HaloTag
    {
        public dctrTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.dctr)
        {

        }
    }

    class decsTag : HaloTag
    {
        public decsTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.decs)
        {

        }
    }

    class drawTag : HaloTag
    {
        public drawTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.draw)
        {

        }
    }

    class drdfTag : HaloTag
    {
        public drdfTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.drdf)
        {

        }
    }

    class dsrcTag : HaloTag
    {
        public dsrcTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.dsrc)
        {

        }
    }

    class effeTag : HaloTag
    {
        public effeTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.effe)
        {

        }
    }

    class effgTag : HaloTag
    {
        public effgTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.effg)
        {

        }
    }

    class efscTag : HaloTag
    {
        public efscTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.efsc)
        {

        }
    }

    class eqipTag : HaloTag
    {
        public eqipTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.eqip)
        {

        }
    }

    class flckTag : HaloTag
    {
        public flckTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.flck)
        {

        }
    }

    class footTag : HaloTag
    {
        public footTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.foot)
        {

        }
    }

    class formTag : HaloTag
    {
        public formTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.form)
        {

        }
    }

    class gfxtTag : HaloTag
    {
        public gfxtTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.gfxt)
        {

        }
    }

    class glpsTag : HaloTag
    {
        public glpsTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.glps)
        {

        }
    }

    class glvsTag : HaloTag
    {
        public glvsTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.glvs)
        {

        }
    }

    class goofTag : HaloTag
    {
        public goofTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.goof)
        {

        }
    }

    class gpdtTag : HaloTag
    {
        public gpdtTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.gpdt)
        {

        }
    }

    class grupTag : HaloTag
    {
        public grupTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.grup)
        {

        }
    }

    class hlmtTag : HaloTag
    {
        public hlmtTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.hlmt)
        {

        }
    }

    class inpgTag : HaloTag
    {
        public inpgTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.inpg)
        {

        }
    }

    class jmadTag : HaloTag
    {
        public jmadTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.jmad)
        {

        }
    }

    class jmrqTag : HaloTag
    {
        public jmrqTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.jmrq)
        {

        }
    }

    class jptTag : HaloTag
    {
        public jptTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.jpt)
        {

        }
    }

    class LbspTag : HaloTag
    {
        public LbspTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.Lbsp)
        {

        }
    }

    class lensTag : HaloTag
    {
        public lensTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.lens)
        {

        }
    }

    class lighTag : HaloTag
    {
        public lighTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.ligh)
        {

        }
    }

    class lsndTag : HaloTag
    {
        public lsndTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.lsnd)
        {

        }
    }

    class lst3Tag : HaloTag
    {
        public lst3Tag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.lst3)
        {

        }
    }

    class ltvlTag : HaloTag
    {
        public ltvlTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.ltvl)
        {

        }
    }

    class machTag : HaloTag
    {
        public machTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.mach)
        {

        }
    }

    class matgTag : HaloTag
    {
        public matgTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.matg)
        {

        }
    }

    class mdl3Tag : HaloTag
    {
        public mdl3Tag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.mdl3)
        {

        }
    }

    class mffnTag : HaloTag
    {
        public mffnTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.mffn)
        {

        }
    }

    class modeTag : HaloTag
    {
        public modeTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.mode)
        {

        }
    }

    class mulgTag : HaloTag
    {
        public mulgTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.mulg)
        {

        }
    }

    class pdmTag : HaloTag
    {
        public pdmTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.pdm)
        {

        }
    }

    class perfTag : HaloTag
    {
        public perfTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.perf)
        {

        }
    }

    class phmoTag : HaloTag
    {
        public phmoTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.phmo)
        {

        }
    }

    class pixlTag : HaloTag
    {
        public pixlTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.pixl)
        {

        }
    }

    class pmdfTag : HaloTag
    {
        public pmdfTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.pmdf)
        {

        }
    }

    class pmovTag : HaloTag
    {
        public pmovTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.pmov)
        {

        }
    }

    class pphyTag : HaloTag
    {
        public pphyTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.pphy)
        {

        }
    }

    class projTag : HaloTag
    {
        public projTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.proj)
        {

        }
    }

    class prt3Tag : HaloTag
    {
        public prt3Tag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.prt3)
        {

        }
    }

    class rasgTag : HaloTag
    {
        public rasgTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.rasg)
        {

        }
    }

    class rmdTag : HaloTag
    {
        public rmdTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.rmd)
        {

        }
    }

    class rmdfTag : HaloTag
    {
        public rmdfTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.rmdf)
        {

        }
    }

    class rmflTag : HaloTag
    {
        public rmflTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.rmfl)
        {

        }
    }

    class rmhgTag : HaloTag
    {
        public rmhgTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.rmhg)
        {

        }
    }

    class rmopTag : HaloTag
    {
        public rmopTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.rmop)
        {

        }
    }

    class rmshTag : HaloTag
    {
        public rmshTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.rmsh)
        {

        }
    }

    class rmssTag : HaloTag
    {
        public rmssTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.rmss)
        {

        }
    }

    class rmt2Tag : HaloTag
    {
        public rmt2Tag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.rmt2)
        {

        }
    }

    class rmtrTag : HaloTag
    {
        public rmtrTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.rmtr)
        {

        }
    }

    class rmwTag : HaloTag
    {
        public rmwTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.rmw)
        {

        }
    }

    class rmzoTag : HaloTag
    {
        public rmzoTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.rmzo)
        {

        }
    }

    class rwrdTag : HaloTag
    {
        public rwrdTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.rwrd)
        {

        }
    }

    class sbspTag : HaloTag
    {
        public sbspTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.sbsp)
        {

        }
    }

    class scenTag : HaloTag
    {
        public scenTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.scen)
        {

        }
    }

    class scn3Tag : HaloTag
    {
        public scn3Tag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.scn3)
        {

        }
    }

    class scnrTag : HaloTag
    {
        public scnrTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.scnr)
        {

        }
    }

    class sddtTag : HaloTag
    {
        public sddtTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.sddt)
        {

        }
    }

    class sefcTag : HaloTag
    {
        public sefcTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.sefc)
        {

        }
    }

    class sfxTag : HaloTag
    {
        public sfxTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.sfx)
        {

        }
    }

    class sgpTag : HaloTag
    {
        public sgpTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.sgp)
        {

        }
    }

    class shitTag : HaloTag
    {
        public shitTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.shit)
        {

        }
    }

    class silyTag : HaloTag
    {
        public silyTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.sily)
        {

        }
    }

    class skn3Tag : HaloTag
    {
        public skn3Tag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.skn3)
        {

        }
    }

    class skyaTag : HaloTag
    {
        public skyaTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.skya)
        {

        }
    }

    class sLdTTag : HaloTag
    {
        public sLdTTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.sLdT)
        {

        }
    }

    class smdtTag : HaloTag
    {
        public smdtTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.smdt)
        {

        }
    }

    class snclTag : HaloTag
    {
        public snclTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.sncl)
        {

        }
    }

    class sndTag : HaloTag
    {
        public sndTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.snd)
        {

        }
    }

    class sndeTag : HaloTag
    {
        public sndeTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.snde)
        {

        }
    }

    class snmxTag : HaloTag
    {
        public snmxTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.snmx)
        {

        }
    }

    class spkTag : HaloTag
    {
        public spkTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.spk)
        {

        }
    }

    class sqtmTag : HaloTag
    {
        public sqtmTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.sqtm)
        {

        }
    }

    class ssceTag : HaloTag
    {
        public ssceTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.ssce)
        {

        }
    }

    class stylTag : HaloTag
    {
        public stylTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.styl)
        {

        }
    }

    class susTag : HaloTag
    {
        public susTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.sus)
        {

        }
    }

    class trakTag : HaloTag
    {
        public trakTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.trak)
        {

        }
    }

    class trdfTag : HaloTag
    {
        public trdfTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.trdf)
        {

        }
    }

    class txt3Tag : HaloTag
    {
        public txt3Tag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.txt3)
        {

        }
    }

    class udlgTag : HaloTag
    {
        public udlgTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.udlg)
        {

        }
    }

    class uiseTag : HaloTag
    {
        public uiseTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.uise)
        {

        }
    }

    class unicTag : HaloTag
    {
        public unicTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.unic)
        {

        }
    }

    class vehiTag : HaloTag
    {
        public vehiTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.vehi)
        {

        }
    }

    class vfslTag : HaloTag
    {
        public vfslTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.vfsl)
        {

        }
    }

    class vmdxTag : HaloTag
    {
        public vmdxTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.vmdx)
        {

        }
    }

    class vtshTag : HaloTag
    {
        public vtshTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.vtsh)
        {

        }
    }

    class wacdTag : HaloTag
    {
        public wacdTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.wacd)
        {

        }
    }

    class wclrTag : HaloTag
    {
        public wclrTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.wclr)
        {

        }
    }

    class weapTag : HaloTag
    {
        public weapTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.weap)
        {

        }
    }

    class wezrTag : HaloTag
    {
        public wezrTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.wezr)
        {

        }
    }

    class wganTag : HaloTag
    {
        public wganTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.wgan)
        {

        }
    }

    class wgtzTag : HaloTag
    {
        public wgtzTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.wgtz)
        {

        }
    }

    class wiglTag : HaloTag
    {
        public wiglTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.wigl)
        {

        }
    }

    class windTag : HaloTag
    {
        public windTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.wind)
        {

        }
    }

    class wposTag : HaloTag
    {
        public wposTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.wpos)
        {

        }
    }

    class wrotTag : HaloTag
    {
        public wrotTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.wrot)
        {

        }
    }

    class wsclTag : HaloTag
    {
        public wsclTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.wscl)
        {

        }
    }

    class wsprTag : HaloTag
    {
        public wsprTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.wspr)
        {

        }
    }

    class wtuvTag : HaloTag
    {
        public wtuvTag(string offset, string size, string name, string displayName)
            : base(offset, size, name, displayName, globals.tagType.wtuv)
        {

        }
    }




}
