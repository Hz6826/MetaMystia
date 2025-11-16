using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Common.UI
{
	// Token: 0x02000357 RID: 855
	[Serializable]
	public sealed class MultiLanguageSprite : ValueType
	{
		// Token: 0x060064B4 RID: 25780 RVA: 0x001EEAD4 File Offset: 0x001ECCD4
		// Note: this type is marked as 'beforefieldinit'.
		static MultiLanguageSprite()
		{
			Il2CppClassPointerStore<MultiLanguageSprite>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "MultiLanguageSprite");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiLanguageSprite>.NativeClassPtr);
			MultiLanguageSprite.NativeFieldInfoPtr_m_Cn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiLanguageSprite>.NativeClassPtr, "m_Cn");
			MultiLanguageSprite.NativeFieldInfoPtr_m_En = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiLanguageSprite>.NativeClassPtr, "m_En");
			MultiLanguageSprite.NativeFieldInfoPtr_m_Jp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiLanguageSprite>.NativeClassPtr, "m_Jp");
			MultiLanguageSprite.NativeFieldInfoPtr_m_Ko = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiLanguageSprite>.NativeClassPtr, "m_Ko");
			MultiLanguageSprite.NativeFieldInfoPtr_m_Cnt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiLanguageSprite>.NativeClassPtr, "m_Cnt");
			MultiLanguageSprite.NativeMethodInfoPtr_get_Current_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiLanguageSprite>.NativeClassPtr, 100684399);
		}

		// Token: 0x170022A6 RID: 8870
		// (get) Token: 0x060064B5 RID: 25781 RVA: 0x001EEB7C File Offset: 0x001ECD7C
		public unsafe Sprite Current
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 258967, RefRangeEnd = 258970, XrefRangeStart = 258966, XrefRangeEnd = 258967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiLanguageSprite.NativeMethodInfoPtr_get_Current_Public_get_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x060064B6 RID: 25782 RVA: 0x0003677F File Offset: 0x0003497F
		public MultiLanguageSprite(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060064B7 RID: 25783 RVA: 0x00036788 File Offset: 0x00034988
		public MultiLanguageSprite() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiLanguageSprite>.NativeClassPtr))
		{
		}

		// Token: 0x170022A1 RID: 8865
		// (get) Token: 0x060064B8 RID: 25784 RVA: 0x001EEBC0 File Offset: 0x001ECDC0
		// (set) Token: 0x060064B9 RID: 25785 RVA: 0x0003679A File Offset: 0x0003499A
		public unsafe Sprite m_Cn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiLanguageSprite.NativeFieldInfoPtr_m_Cn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiLanguageSprite.NativeFieldInfoPtr_m_Cn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022A2 RID: 8866
		// (get) Token: 0x060064BA RID: 25786 RVA: 0x001EEBF0 File Offset: 0x001ECDF0
		// (set) Token: 0x060064BB RID: 25787 RVA: 0x000367B9 File Offset: 0x000349B9
		public unsafe Sprite m_En
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiLanguageSprite.NativeFieldInfoPtr_m_En);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiLanguageSprite.NativeFieldInfoPtr_m_En), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022A3 RID: 8867
		// (get) Token: 0x060064BC RID: 25788 RVA: 0x001EEC20 File Offset: 0x001ECE20
		// (set) Token: 0x060064BD RID: 25789 RVA: 0x000367D8 File Offset: 0x000349D8
		public unsafe Sprite m_Jp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiLanguageSprite.NativeFieldInfoPtr_m_Jp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiLanguageSprite.NativeFieldInfoPtr_m_Jp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022A4 RID: 8868
		// (get) Token: 0x060064BE RID: 25790 RVA: 0x001EEC50 File Offset: 0x001ECE50
		// (set) Token: 0x060064BF RID: 25791 RVA: 0x000367F7 File Offset: 0x000349F7
		public unsafe Sprite m_Ko
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiLanguageSprite.NativeFieldInfoPtr_m_Ko);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiLanguageSprite.NativeFieldInfoPtr_m_Ko), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022A5 RID: 8869
		// (get) Token: 0x060064C0 RID: 25792 RVA: 0x001EEC80 File Offset: 0x001ECE80
		// (set) Token: 0x060064C1 RID: 25793 RVA: 0x00036816 File Offset: 0x00034A16
		public unsafe Sprite m_Cnt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiLanguageSprite.NativeFieldInfoPtr_m_Cnt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiLanguageSprite.NativeFieldInfoPtr_m_Cnt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040042C0 RID: 17088
		private static readonly IntPtr NativeFieldInfoPtr_m_Cn;

		// Token: 0x040042C1 RID: 17089
		private static readonly IntPtr NativeFieldInfoPtr_m_En;

		// Token: 0x040042C2 RID: 17090
		private static readonly IntPtr NativeFieldInfoPtr_m_Jp;

		// Token: 0x040042C3 RID: 17091
		private static readonly IntPtr NativeFieldInfoPtr_m_Ko;

		// Token: 0x040042C4 RID: 17092
		private static readonly IntPtr NativeFieldInfoPtr_m_Cnt;

		// Token: 0x040042C5 RID: 17093
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_get_Sprite_0;
	}
}
