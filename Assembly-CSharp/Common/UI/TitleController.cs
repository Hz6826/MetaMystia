using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x02000358 RID: 856
	public class TitleController : MonoBehaviour
	{
		// Token: 0x060064C2 RID: 25794 RVA: 0x001EECB0 File Offset: 0x001ECEB0
		// Note: this type is marked as 'beforefieldinit'.
		static TitleController()
		{
			Il2CppClassPointerStore<TitleController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "TitleController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TitleController>.NativeClassPtr);
			TitleController.NativeFieldInfoPtr_m_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleController>.NativeClassPtr, "m_Title");
			TitleController.NativeFieldInfoPtr_m_TitleSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleController>.NativeClassPtr, "m_TitleSprite");
			TitleController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleController>.NativeClassPtr, 100684400);
			TitleController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleController>.NativeClassPtr, 100684401);
			TitleController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleController>.NativeClassPtr, 100684402);
			TitleController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleController>.NativeClassPtr, 100684403);
		}

		// Token: 0x060064C3 RID: 25795 RVA: 0x001EED58 File Offset: 0x001ECF58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258970, XrefRangeEnd = 258973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TitleController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064C4 RID: 25796 RVA: 0x001EED8C File Offset: 0x001ECF8C
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TitleController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064C5 RID: 25797 RVA: 0x001EEDC0 File Offset: 0x001ECFC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72640, RefRangeEnd = 72641, XrefRangeStart = 72640, XrefRangeEnd = 72641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TitleController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064C6 RID: 25798 RVA: 0x001EEDFC File Offset: 0x001ECFFC
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TitleController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TitleController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TitleController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064C7 RID: 25799 RVA: 0x00036835 File Offset: 0x00034A35
		public TitleController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170022A7 RID: 8871
		// (get) Token: 0x060064C8 RID: 25800 RVA: 0x001EEE38 File Offset: 0x001ED038
		// (set) Token: 0x060064C9 RID: 25801 RVA: 0x0003683E File Offset: 0x00034A3E
		public unsafe Image m_Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TitleController.NativeFieldInfoPtr_m_Title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TitleController.NativeFieldInfoPtr_m_Title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022A8 RID: 8872
		// (get) Token: 0x060064CA RID: 25802 RVA: 0x001EEE68 File Offset: 0x001ED068
		// (set) Token: 0x060064CB RID: 25803 RVA: 0x0003685D File Offset: 0x00034A5D
		public MultiLanguageSprite m_TitleSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TitleController.NativeFieldInfoPtr_m_TitleSprite);
				return new MultiLanguageSprite(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MultiLanguageSprite>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TitleController.NativeFieldInfoPtr_m_TitleSprite), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MultiLanguageSprite>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040042C6 RID: 17094
		private static readonly IntPtr NativeFieldInfoPtr_m_Title;

		// Token: 0x040042C7 RID: 17095
		private static readonly IntPtr NativeFieldInfoPtr_m_TitleSprite;

		// Token: 0x040042C8 RID: 17096
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040042C9 RID: 17097
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040042CA RID: 17098
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x040042CB RID: 17099
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
