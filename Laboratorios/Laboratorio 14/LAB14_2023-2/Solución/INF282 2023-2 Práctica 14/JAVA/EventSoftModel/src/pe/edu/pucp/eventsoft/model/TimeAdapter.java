package pe.edu.pucp.eventsoft.model;

import java.sql.Time;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import javax.xml.bind.annotation.adapters.XmlAdapter;

public class TimeAdapter extends XmlAdapter<String, Time>{
    @Override
    public Time unmarshal(String v) throws Exception {
        ArrayList<SimpleDateFormat> patrones = new ArrayList<>();
        patrones.add(new SimpleDateFormat("HH:mm"));
        patrones.add(new SimpleDateFormat("hh:mm"));
        for(SimpleDateFormat sdf : patrones){
            try{
                long ms = sdf.parse(v).getTime();
                Time t = (new Time(ms));
                return t;
            }catch(Exception ex){
            }
        }
        return null;
    }
    @Override
    public String marshal(Time v) throws Exception {
        SimpleDateFormat format = new SimpleDateFormat("HH:mm");
        return format.format(v.getTime());
    } 
}
