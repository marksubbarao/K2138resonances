uniform float uv_fade;
uniform float uv_alpha;
uniform vec4 popColor;
uniform sampler2D viridis;

in vec2 texcoord;
in float colorFactor;

out vec4 fragColor;

void main(void)
{	
	float rad = length(texcoord);
	
		//make a circle
		if (rad > 1.){
			discard;
		}

	fragColor = vec4(1.);

	fragColor.a *=  uv_fade * uv_alpha;
		
}
