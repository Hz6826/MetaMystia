using System;
using DEYU.Singletons;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x020003DC RID: 988
	public class GameTimeManager : MonoSingleton<GameTimeManager>
	{
		// Token: 0x060075EE RID: 30190 RVA: 0x00227940 File Offset: 0x00225B40
		// Note: this type is marked as 'beforefieldinit'.
		static GameTimeManager()
		{
			Il2CppClassPointerStore<GameTimeManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "GameTimeManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameTimeManager>.NativeClassPtr);
			GameTimeManager.NativeFieldInfoPtr_CLIP_TIME_DURATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTimeManager>.NativeClassPtr, "CLIP_TIME_DURATION");
			GameTimeManager.NativeFieldInfoPtr_playableDirector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTimeManager>.NativeClassPtr, "playableDirector");
			GameTimeManager.NativeFieldInfoPtr_isPlayablePlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTimeManager>.NativeClassPtr, "isPlayablePlaying");
			GameTimeManager.NativeFieldInfoPtr__ShouldUpdateTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTimeManager>.NativeClassPtr, "<ShouldUpdateTime>k__BackingField");
			GameTimeManager.NativeFieldInfoPtr__DefaultTimeScale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTimeManager>.NativeClassPtr, "<DefaultTimeScale>k__BackingField");
			GameTimeManager.NativeFieldInfoPtr__CurrentTimeMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTimeManager>.NativeClassPtr, "<CurrentTimeMode>k__BackingField");
			GameTimeManager.NativeMethodInfoPtr_get_ShouldUpdateTime_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameTimeManager>.NativeClassPtr, 100687473);
			GameTimeManager.NativeMethodInfoPtr_set_ShouldUpdateTime_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameTimeManager>.NativeClassPtr, 100687474);
			GameTimeManager.NativeMethodInfoPtr_get_DefaultTimeScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameTimeManager>.NativeClassPtr, 100687475);
			GameTimeManager.NativeMethodInfoPtr_set_DefaultTimeScale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameTimeManager>.NativeClassPtr, 100687476);
			GameTimeManager.NativeMethodInfoPtr_get_CurrentTimeMode_Public_get_TimeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameTimeManager>.NativeClassPtr, 100687477);
			GameTimeManager.NativeMethodInfoPtr_set_CurrentTimeMode_Private_set_Void_TimeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameTimeManager>.NativeClassPtr, 100687478);
			GameTimeManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameTimeManager>.NativeClassPtr, 100687479);
			GameTimeManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameTimeManager>.NativeClassPtr, 100687480);
			GameTimeManager.NativeMethodInfoPtr_OnPlayableDirectorPlayed_Private_Void_PlayableDirector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameTimeManager>.NativeClassPtr, 100687481);
			GameTimeManager.NativeMethodInfoPtr_SetGameTimeMode_Public_Void_TimeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameTimeManager>.NativeClassPtr, 100687482);
			GameTimeManager.NativeMethodInfoPtr_AddTicks_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameTimeManager>.NativeClassPtr, 100687483);
			GameTimeManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameTimeManager>.NativeClassPtr, 100687484);
		}

		// Token: 0x1700284D RID: 10317
		// (get) Token: 0x060075EF RID: 30191 RVA: 0x00227AD8 File Offset: 0x00225CD8
		// (set) Token: 0x060075F0 RID: 30192 RVA: 0x00227B14 File Offset: 0x00225D14
		public unsafe bool ShouldUpdateTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameTimeManager.NativeMethodInfoPtr_get_ShouldUpdateTime_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameTimeManager.NativeMethodInfoPtr_set_ShouldUpdateTime_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700284E RID: 10318
		// (get) Token: 0x060075F1 RID: 30193 RVA: 0x00227B54 File Offset: 0x00225D54
		// (set) Token: 0x060075F2 RID: 30194 RVA: 0x00227B90 File Offset: 0x00225D90
		public unsafe float DefaultTimeScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameTimeManager.NativeMethodInfoPtr_get_DefaultTimeScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 292489, RefRangeEnd = 292490, XrefRangeStart = 292489, XrefRangeEnd = 292489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameTimeManager.NativeMethodInfoPtr_set_DefaultTimeScale_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700284F RID: 10319
		// (get) Token: 0x060075F3 RID: 30195 RVA: 0x00227BD0 File Offset: 0x00225DD0
		// (set) Token: 0x060075F4 RID: 30196 RVA: 0x00227C0C File Offset: 0x00225E0C
		public unsafe GameTimeManager.TimeMode CurrentTimeMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 49351, RefRangeEnd = 49352, XrefRangeStart = 49351, XrefRangeEnd = 49352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameTimeManager.NativeMethodInfoPtr_get_CurrentTimeMode_Public_get_TimeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameTimeManager.NativeMethodInfoPtr_set_CurrentTimeMode_Private_set_Void_TimeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060075F5 RID: 30197 RVA: 0x00227C4C File Offset: 0x00225E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292490, XrefRangeEnd = 292499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameTimeManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075F6 RID: 30198 RVA: 0x00227C88 File Offset: 0x00225E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292499, XrefRangeEnd = 292504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameTimeManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075F7 RID: 30199 RVA: 0x00227CBC File Offset: 0x00225EBC
		[CallerCount(0)]
		public unsafe void OnPlayableDirectorPlayed(PlayableDirector playableDirector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playableDirector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameTimeManager.NativeMethodInfoPtr_OnPlayableDirectorPlayed_Private_Void_PlayableDirector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075F8 RID: 30200 RVA: 0x00227D00 File Offset: 0x00225F00
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 292509, RefRangeEnd = 292552, XrefRangeStart = 292504, XrefRangeEnd = 292509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGameTimeMode(GameTimeManager.TimeMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameTimeManager.NativeMethodInfoPtr_SetGameTimeMode_Public_Void_TimeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075F9 RID: 30201 RVA: 0x00227D40 File Offset: 0x00225F40
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 292555, RefRangeEnd = 292564, XrefRangeStart = 292552, XrefRangeEnd = 292555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTicks(int ticks)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ticks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameTimeManager.NativeMethodInfoPtr_AddTicks_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075FA RID: 30202 RVA: 0x00227D80 File Offset: 0x00225F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292564, XrefRangeEnd = 292567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameTimeManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameTimeManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameTimeManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075FB RID: 30203 RVA: 0x0003FD08 File Offset: 0x0003DF08
		public GameTimeManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002847 RID: 10311
		// (get) Token: 0x060075FC RID: 30204 RVA: 0x00227DBC File Offset: 0x00225FBC
		// (set) Token: 0x060075FD RID: 30205 RVA: 0x0003FD11 File Offset: 0x0003DF11
		public unsafe static float CLIP_TIME_DURATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GameTimeManager.NativeFieldInfoPtr_CLIP_TIME_DURATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameTimeManager.NativeFieldInfoPtr_CLIP_TIME_DURATION, (void*)(&value));
			}
		}

		// Token: 0x17002848 RID: 10312
		// (get) Token: 0x060075FE RID: 30206 RVA: 0x00227DD8 File Offset: 0x00225FD8
		// (set) Token: 0x060075FF RID: 30207 RVA: 0x0003FD1F File Offset: 0x0003DF1F
		public unsafe PlayableDirector playableDirector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTimeManager.NativeFieldInfoPtr_playableDirector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayableDirector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTimeManager.NativeFieldInfoPtr_playableDirector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002849 RID: 10313
		// (get) Token: 0x06007600 RID: 30208 RVA: 0x00227E08 File Offset: 0x00226008
		// (set) Token: 0x06007601 RID: 30209 RVA: 0x0003FD3E File Offset: 0x0003DF3E
		public unsafe bool isPlayablePlaying
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTimeManager.NativeFieldInfoPtr_isPlayablePlaying);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTimeManager.NativeFieldInfoPtr_isPlayablePlaying)) = value;
			}
		}

		// Token: 0x1700284A RID: 10314
		// (get) Token: 0x06007602 RID: 30210 RVA: 0x00227E30 File Offset: 0x00226030
		// (set) Token: 0x06007603 RID: 30211 RVA: 0x0003FD59 File Offset: 0x0003DF59
		public unsafe bool _ShouldUpdateTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTimeManager.NativeFieldInfoPtr__ShouldUpdateTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTimeManager.NativeFieldInfoPtr__ShouldUpdateTime_k__BackingField)) = value;
			}
		}

		// Token: 0x1700284B RID: 10315
		// (get) Token: 0x06007604 RID: 30212 RVA: 0x00227E58 File Offset: 0x00226058
		// (set) Token: 0x06007605 RID: 30213 RVA: 0x0003FD74 File Offset: 0x0003DF74
		public unsafe float _DefaultTimeScale_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTimeManager.NativeFieldInfoPtr__DefaultTimeScale_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTimeManager.NativeFieldInfoPtr__DefaultTimeScale_k__BackingField)) = value;
			}
		}

		// Token: 0x1700284C RID: 10316
		// (get) Token: 0x06007606 RID: 30214 RVA: 0x00227E80 File Offset: 0x00226080
		// (set) Token: 0x06007607 RID: 30215 RVA: 0x0003FD8F File Offset: 0x0003DF8F
		public unsafe GameTimeManager.TimeMode _CurrentTimeMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTimeManager.NativeFieldInfoPtr__CurrentTimeMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTimeManager.NativeFieldInfoPtr__CurrentTimeMode_k__BackingField)) = value;
			}
		}

		// Token: 0x04004E21 RID: 20001
		private static readonly IntPtr NativeFieldInfoPtr_CLIP_TIME_DURATION;

		// Token: 0x04004E22 RID: 20002
		private static readonly IntPtr NativeFieldInfoPtr_playableDirector;

		// Token: 0x04004E23 RID: 20003
		private static readonly IntPtr NativeFieldInfoPtr_isPlayablePlaying;

		// Token: 0x04004E24 RID: 20004
		private static readonly IntPtr NativeFieldInfoPtr__ShouldUpdateTime_k__BackingField;

		// Token: 0x04004E25 RID: 20005
		private static readonly IntPtr NativeFieldInfoPtr__DefaultTimeScale_k__BackingField;

		// Token: 0x04004E26 RID: 20006
		private static readonly IntPtr NativeFieldInfoPtr__CurrentTimeMode_k__BackingField;

		// Token: 0x04004E27 RID: 20007
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldUpdateTime_Public_get_Boolean_0;

		// Token: 0x04004E28 RID: 20008
		private static readonly IntPtr NativeMethodInfoPtr_set_ShouldUpdateTime_Public_set_Void_Boolean_0;

		// Token: 0x04004E29 RID: 20009
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultTimeScale_Public_get_Single_0;

		// Token: 0x04004E2A RID: 20010
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultTimeScale_Public_set_Void_Single_0;

		// Token: 0x04004E2B RID: 20011
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentTimeMode_Public_get_TimeMode_0;

		// Token: 0x04004E2C RID: 20012
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentTimeMode_Private_set_Void_TimeMode_0;

		// Token: 0x04004E2D RID: 20013
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04004E2E RID: 20014
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004E2F RID: 20015
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayableDirectorPlayed_Private_Void_PlayableDirector_0;

		// Token: 0x04004E30 RID: 20016
		private static readonly IntPtr NativeMethodInfoPtr_SetGameTimeMode_Public_Void_TimeMode_0;

		// Token: 0x04004E31 RID: 20017
		private static readonly IntPtr NativeMethodInfoPtr_AddTicks_Public_Void_Int32_0;

		// Token: 0x04004E32 RID: 20018
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000F81 RID: 3969
		public enum TimeMode
		{
			// Token: 0x0400AE03 RID: 44547
			Freeze,
			// Token: 0x0400AE04 RID: 44548
			HalfFreeze,
			// Token: 0x0400AE05 RID: 44549
			Resume
		}
	}
}
