using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace Common.UI.CreatorsBox
{
	// Token: 0x020003CF RID: 975
	public class CreatorsBoxTimelineInBetweenElement : MonoBehaviour
	{
		// Token: 0x06007431 RID: 29745 RVA: 0x00221A3C File Offset: 0x0021FC3C
		// Note: this type is marked as 'beforefieldinit'.
		static CreatorsBoxTimelineInBetweenElement()
		{
			Il2CppClassPointerStore<CreatorsBoxTimelineInBetweenElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.CreatorsBox", "CreatorsBoxTimelineInBetweenElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorsBoxTimelineInBetweenElement>.NativeClassPtr);
			CreatorsBoxTimelineInBetweenElement.NativeFieldInfoPtr_m_AmountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorsBoxTimelineInBetweenElement>.NativeClassPtr, "m_AmountText");
			CreatorsBoxTimelineInBetweenElement.NativeFieldInfoPtr_m_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorsBoxTimelineInBetweenElement>.NativeClassPtr, "m_CanvasGroup");
			CreatorsBoxTimelineInBetweenElement.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorsBoxTimelineInBetweenElement>.NativeClassPtr, 100687186);
			CreatorsBoxTimelineInBetweenElement.NativeMethodInfoPtr_Setup_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorsBoxTimelineInBetweenElement>.NativeClassPtr, 100687187);
			CreatorsBoxTimelineInBetweenElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorsBoxTimelineInBetweenElement>.NativeClassPtr, 100687188);
		}

		// Token: 0x06007432 RID: 29746 RVA: 0x00221AD0 File Offset: 0x0021FCD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289343, XrefRangeEnd = 289347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorsBoxTimelineInBetweenElement.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007433 RID: 29747 RVA: 0x00221B04 File Offset: 0x0021FD04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289350, RefRangeEnd = 289351, XrefRangeStart = 289347, XrefRangeEnd = 289350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorsBoxTimelineInBetweenElement.NativeMethodInfoPtr_Setup_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007434 RID: 29748 RVA: 0x00221B44 File Offset: 0x0021FD44
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreatorsBoxTimelineInBetweenElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorsBoxTimelineInBetweenElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorsBoxTimelineInBetweenElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007435 RID: 29749 RVA: 0x0003EE9F File Offset: 0x0003D09F
		public CreatorsBoxTimelineInBetweenElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027C2 RID: 10178
		// (get) Token: 0x06007436 RID: 29750 RVA: 0x00221B80 File Offset: 0x0021FD80
		// (set) Token: 0x06007437 RID: 29751 RVA: 0x0003EEA8 File Offset: 0x0003D0A8
		public unsafe TextMeshProUGUI m_AmountText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineInBetweenElement.NativeFieldInfoPtr_m_AmountText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineInBetweenElement.NativeFieldInfoPtr_m_AmountText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027C3 RID: 10179
		// (get) Token: 0x06007438 RID: 29752 RVA: 0x00221BB0 File Offset: 0x0021FDB0
		// (set) Token: 0x06007439 RID: 29753 RVA: 0x0003EEC7 File Offset: 0x0003D0C7
		public unsafe CanvasGroup m_CanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineInBetweenElement.NativeFieldInfoPtr_m_CanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineInBetweenElement.NativeFieldInfoPtr_m_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004CF8 RID: 19704
		private static readonly IntPtr NativeFieldInfoPtr_m_AmountText;

		// Token: 0x04004CF9 RID: 19705
		private static readonly IntPtr NativeFieldInfoPtr_m_CanvasGroup;

		// Token: 0x04004CFA RID: 19706
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004CFB RID: 19707
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_Int32_0;

		// Token: 0x04004CFC RID: 19708
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
