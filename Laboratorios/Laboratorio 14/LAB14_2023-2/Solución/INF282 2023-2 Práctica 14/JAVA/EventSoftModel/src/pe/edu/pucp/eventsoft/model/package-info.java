@XmlJavaTypeAdapters({
    @XmlJavaTypeAdapter(value=TimeAdapter.class)
})
package pe.edu.pucp.eventsoft.model;

import javax.xml.bind.annotation.adapters.XmlJavaTypeAdapter;
import javax.xml.bind.annotation.adapters.XmlJavaTypeAdapters;