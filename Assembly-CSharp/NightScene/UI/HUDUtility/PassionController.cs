using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace NightScene.UI.HUDUtility
{
	// Token: 0x020001CD RID: 461
	public class PassionController : MonoBehaviour
	{
		// Token: 0x060039E0 RID: 14816 RVA: 0x00163EB0 File Offset: 0x001620B0
		// Note: this type is marked as 'beforefieldinit'.
		static PassionController()
		{
			Il2CppClassPointerStore<PassionController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI.HUDUtility", "PassionController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PassionController>.NativeClassPtr);
			PassionController.NativeFieldInfoPtr_fill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassionController>.NativeClassPtr, "fill");
			PassionController.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassionController>.NativeClassPtr, "i");
			PassionController.NativeFieldInfoPtr_ii = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassionController>.NativeClassPtr, "ii");
			PassionController.NativeFieldInfoPtr_iii = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassionController>.NativeClassPtr, "iii");
			PassionController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassionController>.NativeClassPtr, 100674081);
			PassionController.NativeMethodInfoPtr_SetValue_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassionController>.NativeClassPtr, 100674082);
			PassionController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassionController>.NativeClassPtr, 100674083);
			PassionController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassionController>.NativeClassPtr, 100674084);
		}

		// Token: 0x060039E1 RID: 14817 RVA: 0x00163F80 File Offset: 0x00162180
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassionController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039E2 RID: 14818 RVA: 0x00163FB4 File Offset: 0x001621B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131864, RefRangeEnd = 131865, XrefRangeStart = 131863, XrefRangeEnd = 131864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(int percentage, int musicLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref percentage;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref musicLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassionController.NativeMethodInfoPtr_SetValue_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039E3 RID: 14819 RVA: 0x00164000 File Offset: 0x00162200
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72640, RefRangeEnd = 72641, XrefRangeStart = 72640, XrefRangeEnd = 72641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PassionController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039E4 RID: 14820 RVA: 0x0016403C File Offset: 0x0016223C
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PassionController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PassionController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassionController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039E5 RID: 14821 RVA: 0x0002069A File Offset: 0x0001E89A
		public PassionController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170013F5 RID: 5109
		// (get) Token: 0x060039E6 RID: 14822 RVA: 0x00164078 File Offset: 0x00162278
		// (set) Token: 0x060039E7 RID: 14823 RVA: 0x000206A3 File Offset: 0x0001E8A3
		public unsafe Image fill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassionController.NativeFieldInfoPtr_fill);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassionController.NativeFieldInfoPtr_fill), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013F6 RID: 5110
		// (get) Token: 0x060039E8 RID: 14824 RVA: 0x001640A8 File Offset: 0x001622A8
		// (set) Token: 0x060039E9 RID: 14825 RVA: 0x000206C2 File Offset: 0x0001E8C2
		public unsafe Color i
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassionController.NativeFieldInfoPtr_i);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassionController.NativeFieldInfoPtr_i)) = value;
			}
		}

		// Token: 0x170013F7 RID: 5111
		// (get) Token: 0x060039EA RID: 14826 RVA: 0x001640D0 File Offset: 0x001622D0
		// (set) Token: 0x060039EB RID: 14827 RVA: 0x000206DD File Offset: 0x0001E8DD
		public unsafe Color ii
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassionController.NativeFieldInfoPtr_ii);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassionController.NativeFieldInfoPtr_ii)) = value;
			}
		}

		// Token: 0x170013F8 RID: 5112
		// (get) Token: 0x060039EC RID: 14828 RVA: 0x001640F8 File Offset: 0x001622F8
		// (set) Token: 0x060039ED RID: 14829 RVA: 0x000206F8 File Offset: 0x0001E8F8
		public unsafe Color iii
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassionController.NativeFieldInfoPtr_iii);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassionController.NativeFieldInfoPtr_iii)) = value;
			}
		}

		// Token: 0x040026F0 RID: 9968
		private static readonly IntPtr NativeFieldInfoPtr_fill;

		// Token: 0x040026F1 RID: 9969
		private static readonly IntPtr NativeFieldInfoPtr_i;

		// Token: 0x040026F2 RID: 9970
		private static readonly IntPtr NativeFieldInfoPtr_ii;

		// Token: 0x040026F3 RID: 9971
		private static readonly IntPtr NativeFieldInfoPtr_iii;

		// Token: 0x040026F4 RID: 9972
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040026F5 RID: 9973
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Int32_Int32_0;

		// Token: 0x040026F6 RID: 9974
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x040026F7 RID: 9975
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
