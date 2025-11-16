using System;
using DEYU.Utils.MaterialController;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Common.VFX
{
	// Token: 0x0200034E RID: 846
	public class UIDistortionMaterialController : MaterialControllerBase
	{
		// Token: 0x0600643B RID: 25659 RVA: 0x001ED418 File Offset: 0x001EB618
		// Note: this type is marked as 'beforefieldinit'.
		static UIDistortionMaterialController()
		{
			Il2CppClassPointerStore<UIDistortionMaterialController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.VFX", "UIDistortionMaterialController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDistortionMaterialController>.NativeClassPtr);
			UIDistortionMaterialController.NativeFieldInfoPtr_mainTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDistortionMaterialController>.NativeClassPtr, "mainTex");
			UIDistortionMaterialController.NativeFieldInfoPtr_noiseTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDistortionMaterialController>.NativeClassPtr, "noiseTex");
			UIDistortionMaterialController.NativeFieldInfoPtr_noiseTex2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDistortionMaterialController>.NativeClassPtr, "noiseTex2");
			UIDistortionMaterialController.NativeFieldInfoPtr_mainColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDistortionMaterialController>.NativeClassPtr, "mainColor");
			UIDistortionMaterialController.NativeFieldInfoPtr_dissiolve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDistortionMaterialController>.NativeClassPtr, "dissiolve");
			UIDistortionMaterialController.NativeFieldInfoPtr_edgeWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDistortionMaterialController>.NativeClassPtr, "edgeWidth");
			UIDistortionMaterialController.NativeFieldInfoPtr_edgeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDistortionMaterialController>.NativeClassPtr, "edgeColor");
			UIDistortionMaterialController.NativeFieldInfoPtr_edgePower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDistortionMaterialController>.NativeClassPtr, "edgePower");
			UIDistortionMaterialController.NativeFieldInfoPtr_noiseSpeed_U = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDistortionMaterialController>.NativeClassPtr, "noiseSpeed_U");
			UIDistortionMaterialController.NativeFieldInfoPtr_noiseSpeed_V = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDistortionMaterialController>.NativeClassPtr, "noiseSpeed_V");
			UIDistortionMaterialController.NativeFieldInfoPtr_noiseSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDistortionMaterialController>.NativeClassPtr, "noiseSpeed");
			UIDistortionMaterialController.NativeFieldInfoPtr_noise_uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDistortionMaterialController>.NativeClassPtr, "noise_uv");
			UIDistortionMaterialController.NativeFieldInfoPtr_lerp_Alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDistortionMaterialController>.NativeClassPtr, "lerp_Alpha");
			UIDistortionMaterialController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDistortionMaterialController>.NativeClassPtr, 100684292);
			UIDistortionMaterialController.NativeMethodInfoPtr_OnUpdatingAllProperties_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDistortionMaterialController>.NativeClassPtr, 100684293);
			UIDistortionMaterialController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDistortionMaterialController>.NativeClassPtr, 100684294);
			UIDistortionMaterialController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDistortionMaterialController>.NativeClassPtr, 100684295);
		}

		// Token: 0x0600643C RID: 25660 RVA: 0x001ED59C File Offset: 0x001EB79C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 67544, RefRangeEnd = 67546, XrefRangeStart = 67544, XrefRangeEnd = 67546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDistortionMaterialController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600643D RID: 25661 RVA: 0x001ED5D0 File Offset: 0x001EB7D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257720, XrefRangeEnd = 257759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUpdatingAllProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIDistortionMaterialController.NativeMethodInfoPtr_OnUpdatingAllProperties_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600643E RID: 25662 RVA: 0x001ED60C File Offset: 0x001EB80C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257759, XrefRangeEnd = 257763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIDistortionMaterialController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600643F RID: 25663 RVA: 0x001ED648 File Offset: 0x001EB848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257763, XrefRangeEnd = 257764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIDistortionMaterialController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIDistortionMaterialController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDistortionMaterialController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006440 RID: 25664 RVA: 0x00036362 File Offset: 0x00034562
		public UIDistortionMaterialController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002283 RID: 8835
		// (get) Token: 0x06006441 RID: 25665 RVA: 0x001ED684 File Offset: 0x001EB884
		// (set) Token: 0x06006442 RID: 25666 RVA: 0x0003636B File Offset: 0x0003456B
		public unsafe Texture2D mainTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDistortionMaterialController.NativeFieldInfoPtr_mainTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDistortionMaterialController.NativeFieldInfoPtr_mainTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002284 RID: 8836
		// (get) Token: 0x06006443 RID: 25667 RVA: 0x001ED6B4 File Offset: 0x001EB8B4
		// (set) Token: 0x06006444 RID: 25668 RVA: 0x0003638A File Offset: 0x0003458A
		public unsafe Texture2D noiseTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDistortionMaterialController.NativeFieldInfoPtr_noiseTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDistortionMaterialController.NativeFieldInfoPtr_noiseTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002285 RID: 8837
		// (get) Token: 0x06006445 RID: 25669 RVA: 0x001ED6E4 File Offset: 0x001EB8E4
		// (set) Token: 0x06006446 RID: 25670 RVA: 0x000363A9 File Offset: 0x000345A9
		public unsafe Texture2D noiseTex2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDistortionMaterialController.NativeFieldInfoPtr_noiseTex2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDistortionMaterialController.NativeFieldInfoPtr_noiseTex2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002286 RID: 8838
		// (get) Token: 0x06006447 RID: 25671 RVA: 0x001ED714 File Offset: 0x001EB914
		// (set) Token: 0x06006448 RID: 25672 RVA: 0x000363C8 File Offset: 0x000345C8
		public unsafe Color mainColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDistortionMaterialController.NativeFieldInfoPtr_mainColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDistortionMaterialController.NativeFieldInfoPtr_mainColor)) = value;
			}
		}

		// Token: 0x17002287 RID: 8839
		// (get) Token: 0x06006449 RID: 25673 RVA: 0x001ED73C File Offset: 0x001EB93C
		// (set) Token: 0x0600644A RID: 25674 RVA: 0x000363E3 File Offset: 0x000345E3
		public unsafe float dissiolve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDistortionMaterialController.NativeFieldInfoPtr_dissiolve);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDistortionMaterialController.NativeFieldInfoPtr_dissiolve)) = value;
			}
		}

		// Token: 0x17002288 RID: 8840
		// (get) Token: 0x0600644B RID: 25675 RVA: 0x001ED764 File Offset: 0x001EB964
		// (set) Token: 0x0600644C RID: 25676 RVA: 0x000363FE File Offset: 0x000345FE
		public unsafe float edgeWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDistortionMaterialController.NativeFieldInfoPtr_edgeWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDistortionMaterialController.NativeFieldInfoPtr_edgeWidth)) = value;
			}
		}

		// Token: 0x17002289 RID: 8841
		// (get) Token: 0x0600644D RID: 25677 RVA: 0x001ED78C File Offset: 0x001EB98C
		// (set) Token: 0x0600644E RID: 25678 RVA: 0x00036419 File Offset: 0x00034619
		public unsafe Color edgeColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDistortionMaterialController.NativeFieldInfoPtr_edgeColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDistortionMaterialController.NativeFieldInfoPtr_edgeColor)) = value;
			}
		}

		// Token: 0x1700228A RID: 8842
		// (get) Token: 0x0600644F RID: 25679 RVA: 0x001ED7B4 File Offset: 0x001EB9B4
		// (set) Token: 0x06006450 RID: 25680 RVA: 0x00036434 File Offset: 0x00034634
		public unsafe float edgePower
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDistortionMaterialController.NativeFieldInfoPtr_edgePower);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDistortionMaterialController.NativeFieldInfoPtr_edgePower)) = value;
			}
		}

		// Token: 0x1700228B RID: 8843
		// (get) Token: 0x06006451 RID: 25681 RVA: 0x001ED7DC File Offset: 0x001EB9DC
		// (set) Token: 0x06006452 RID: 25682 RVA: 0x0003644F File Offset: 0x0003464F
		public unsafe float noiseSpeed_U
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDistortionMaterialController.NativeFieldInfoPtr_noiseSpeed_U);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDistortionMaterialController.NativeFieldInfoPtr_noiseSpeed_U)) = value;
			}
		}

		// Token: 0x1700228C RID: 8844
		// (get) Token: 0x06006453 RID: 25683 RVA: 0x001ED804 File Offset: 0x001EBA04
		// (set) Token: 0x06006454 RID: 25684 RVA: 0x0003646A File Offset: 0x0003466A
		public unsafe float noiseSpeed_V
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDistortionMaterialController.NativeFieldInfoPtr_noiseSpeed_V);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDistortionMaterialController.NativeFieldInfoPtr_noiseSpeed_V)) = value;
			}
		}

		// Token: 0x1700228D RID: 8845
		// (get) Token: 0x06006455 RID: 25685 RVA: 0x001ED82C File Offset: 0x001EBA2C
		// (set) Token: 0x06006456 RID: 25686 RVA: 0x00036485 File Offset: 0x00034685
		public unsafe float noiseSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDistortionMaterialController.NativeFieldInfoPtr_noiseSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDistortionMaterialController.NativeFieldInfoPtr_noiseSpeed)) = value;
			}
		}

		// Token: 0x1700228E RID: 8846
		// (get) Token: 0x06006457 RID: 25687 RVA: 0x001ED854 File Offset: 0x001EBA54
		// (set) Token: 0x06006458 RID: 25688 RVA: 0x000364A0 File Offset: 0x000346A0
		public unsafe Vector4 noise_uv
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDistortionMaterialController.NativeFieldInfoPtr_noise_uv);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDistortionMaterialController.NativeFieldInfoPtr_noise_uv)) = value;
			}
		}

		// Token: 0x1700228F RID: 8847
		// (get) Token: 0x06006459 RID: 25689 RVA: 0x001ED87C File Offset: 0x001EBA7C
		// (set) Token: 0x0600645A RID: 25690 RVA: 0x000364BB File Offset: 0x000346BB
		public unsafe float lerp_Alpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDistortionMaterialController.NativeFieldInfoPtr_lerp_Alpha);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDistortionMaterialController.NativeFieldInfoPtr_lerp_Alpha)) = value;
			}
		}

		// Token: 0x04004277 RID: 17015
		private static readonly IntPtr NativeFieldInfoPtr_mainTex;

		// Token: 0x04004278 RID: 17016
		private static readonly IntPtr NativeFieldInfoPtr_noiseTex;

		// Token: 0x04004279 RID: 17017
		private static readonly IntPtr NativeFieldInfoPtr_noiseTex2;

		// Token: 0x0400427A RID: 17018
		private static readonly IntPtr NativeFieldInfoPtr_mainColor;

		// Token: 0x0400427B RID: 17019
		private static readonly IntPtr NativeFieldInfoPtr_dissiolve;

		// Token: 0x0400427C RID: 17020
		private static readonly IntPtr NativeFieldInfoPtr_edgeWidth;

		// Token: 0x0400427D RID: 17021
		private static readonly IntPtr NativeFieldInfoPtr_edgeColor;

		// Token: 0x0400427E RID: 17022
		private static readonly IntPtr NativeFieldInfoPtr_edgePower;

		// Token: 0x0400427F RID: 17023
		private static readonly IntPtr NativeFieldInfoPtr_noiseSpeed_U;

		// Token: 0x04004280 RID: 17024
		private static readonly IntPtr NativeFieldInfoPtr_noiseSpeed_V;

		// Token: 0x04004281 RID: 17025
		private static readonly IntPtr NativeFieldInfoPtr_noiseSpeed;

		// Token: 0x04004282 RID: 17026
		private static readonly IntPtr NativeFieldInfoPtr_noise_uv;

		// Token: 0x04004283 RID: 17027
		private static readonly IntPtr NativeFieldInfoPtr_lerp_Alpha;

		// Token: 0x04004284 RID: 17028
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04004285 RID: 17029
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdatingAllProperties_Protected_Virtual_Void_0;

		// Token: 0x04004286 RID: 17030
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004287 RID: 17031
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
